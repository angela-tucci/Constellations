/*
Author: Angela Tucci
Date: 12/30/2016
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Constellations.Model;
using Constellations.Data;
using System.Globalization;

namespace Constellations.UI
{
    public partial class AdvancedSearchForm : Form
    {
        private IEnumerable<Constellation> constellations; //list to hold all constellations

        public AdvancedSearchForm(BindingSource bsHemisphere, BindingSource bsMonth)
        {
            InitializeComponent();

            //method calls to set up combo boxes
            InitializeComboBoxChooseRepo();
            InitializeComboBoxSelectHemisphere(bsHemisphere);
            InitializeComboBoxSelectMonth(bsMonth);

            //hide labels and boxes as needed
            labelSelectMonth.Hide();
            comboBoxSelectMonth.Hide();
            buttonSearch.Hide();
            listBoxResults.Hide();
            buttonViewImages.Hide();

            HideLabelsAndBoxes();
        }

        //on load method
        private void CalenderLookUpForm_Load(object sender, EventArgs e)
        {
            //method call to get the list of constellations based on the chosen repository
            InitializeConstellations(RepoFactory.GetRepo(comboBoxChooseRepo.SelectedItem.ToString()));
        }

        //method to set up the repository combo box
        private void InitializeComboBoxChooseRepo()
        {
            //create a new binding source
            BindingSource bs = new BindingSource();

            //set the data source to contain the name of each constellation in the list
            bs.DataSource = from var in Assembly.GetExecutingAssembly().GetTypes()
                            where typeof(IConstellationData).IsAssignableFrom(var) &&
                                var.Name != "IConstellationData"
                            select var.Name;

            //set the combo box data source to the binding source
            comboBoxChooseRepo.DataSource = bs;
        }

        //method to get the list of all constellations
        private void InitializeConstellations(IConstellationData info)
        {
            //get all constellations
            constellations = info.GetConstellationInfo();
        }

        //method to set up th heimsphere combo box
        private void InitializeComboBoxSelectHemisphere(BindingSource bsHemp)
        {
            //set the data source for the combo box
            comboBoxSelectHemisphere.DataSource = bsHemp;
            //set the initial selected index
            comboBoxSelectHemisphere.SelectedIndex = -1;
        }

        //method to set up the month combo box
        private void InitializeComboBoxSelectMonth(BindingSource bsMonth)
        {
            //set the data source for the combo box
            comboBoxSelectMonth.DataSource = bsMonth;
        }

        //method for when the user selects a different hemisphere
        private void comboBoxSelectHemisphere_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the selected index isn't -1...
            if (comboBoxSelectHemisphere.SelectedIndex != -1)
            {
                //variable to hold the selected item
                string hemisphere = comboBoxSelectHemisphere.SelectedItem.ToString();

                //create an IEnumerable that contains all the constellations with the selected hemisphere
                var results = from constell in constellations
                              where constell.Hemisphere.Equals(hemisphere)
                              select constell;

                //create an IEnumerable that contains each unique month from the results
                var allMonths = from constell in results
                                group constell by constell.BestSeen
                                into c
                                select c.First().BestSeen;

                //create an IEnumerable of sorted months
                var sortedMonths = from month in allMonths
                                   orderby DateTime.ParseExact(month, "MMMM", CultureInfo.InvariantCulture)
                                   select month;

                //create a new binding source and set the data source to the sorted months
                BindingSource bs = new BindingSource();
                bs.DataSource = sortedMonths;

                //set the binding source to the combo box
                comboBoxSelectMonth.DataSource = bs;

                //show and hide items as necessary
                labelSelectMonth.Show();
                comboBoxSelectMonth.Show();
                comboBoxSelectMonth.SelectedIndex = -1;
                buttonSearch.Hide();
                listBoxResults.Hide();
                labelTotalResults.Hide();
                buttonViewImages.Hide();

                HideLabelsAndBoxes();
            }
        }

        //method for when the user selects a different month
        private void comboBoxSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if the selected index ins't -1...
            if (comboBoxSelectMonth.SelectedIndex != -1)
            {
                //show and hide items as needed
                buttonSearch.Show();
                listBoxResults.Hide();
                labelTotalResults.Hide();
                buttonViewImages.Hide();
            }
            HideLabelsAndBoxes();
        }

        //method for when the user clicks the Search button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            string hemisphere = comboBoxSelectHemisphere.SelectedItem.ToString();
            string month = comboBoxSelectMonth.SelectedItem.ToString();

            if(comboBoxSelectHemisphere.SelectedIndex == -1 || comboBoxSelectMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Select a hemisphere and month");
            }

            else
            {
                IEnumerable<Constellation> results = from constell in constellations
                                                     where constell.Hemisphere.Equals(hemisphere)
                                                     select constell;

                BindingSource bsResults = new BindingSource();
                bsResults.DataSource = from constell in results
                                       where constell.BestSeen.Equals(month)
                                       select constell.Name.ToString();

                listBoxResults.DataSource = bsResults;
                
                labelTotalResults.Text = $"Total Results: {bsResults.Count}";
                labelTotalResults.Show();

                if (bsResults.Count > 0)
                {
                    listBoxResults.Show();
                    buttonViewImages.Show();

                    //show labels and boxes
                    labelName.Show();
                    labelGenitive.Show();
                    labelAbbreviation.Show();
                    labelBrightestStar.Show();
                    labelFamily.Show();
                    labelOrigin.Show();
                    labelMeaning.Show();
                    labelMythology.Show();
                    labelNearbyConstellations.Show();
                    richTextBoxMythology.Show();
                    richTextBoxNearbyConstellations.Show();
                }
                //otherwise there were no results
                else
                {
                    //display a message
                    MessageBox.Show("No results");
                }
            }
        }

        //method to hide all labels and boxes in the constellation information section
        private void HideLabelsAndBoxes()
        {
            //hide the labels and rich text boxes
            labelName.Hide();
            labelGenitive.Hide();
            labelAbbreviation.Hide();
            labelBrightestStar.Hide();
            labelFamily.Hide();
            labelOrigin.Hide();
            labelMeaning.Hide();
            labelMythology.Hide();
            labelNearbyConstellations.Hide();
            richTextBoxMythology.Hide();
            richTextBoxNearbyConstellations.Hide();
        }

        //method for when the user selects a different constellation from the list box
        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create a list to be iterated through
            List<Constellation> list = constellations.ToList();

            for(int i = 0; i < list.Count; i++)
            {
                //if the current name is the same as the selected list box item
                //and the selected index isn't -1...
                if(list[i].Name == listBoxResults.SelectedItem.ToString() 
                    && listBoxResults.SelectedIndex > -1)
                {
                    //set all of the labels to display information about the constellation
                    labelName.Text = list[i].Name;
                    labelAbbreviation.Text = $"Abbreviation: {list[i].Abbreviation}";
                    labelGenitive.Text = $"Genitive: {list[i].Genitive}";
                    labelFamily.Text = $"Family: {list[i].Family}";
                    labelOrigin.Text = $"Origin: {list[i].Origin}";
                    labelMeaning.Text = $"Meaning: {list[i].Meaning}";
                    labelBrightestStar.Text = $"Brightest Star: {list[i].BrightestStar}";
                    richTextBoxNearbyConstellations.Text = list[i].NearbyConstellations;
                    richTextBoxMythology.Text = list[i].Mythology;

                    //set the font of the name label
                    labelName.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);

                    //reset i to force quit the loop
                    i = list.Count;
                }
            }
        }

        //method for when the user selects the View Images button
        private void buttonViewImages_Click(object sender, EventArgs e)
        {
            //create variables for name and the image paths
            string name = listBoxResults.SelectedItem.ToString();
            string skyImagePath = "", starsMapPath = "", mythImagePath = "";

            //convert constellations to a list
            List<Constellation> list = constellations.ToList();
            //iterate the list
            for(int i = 0; i < list.Count; i++)
            {
                //if the name equals the selected item in the list box...
                if(list[i].Name == name)
                {
                    //set the variables
                    skyImagePath = list[i].ImagePathSky;
                    starsMapPath = list[i].ImagePathStars;
                    mythImagePath = list[i].ImagePathPicture;

                    //reset i to force quit the loop
                    i = list.Count;
                }
            }

            //create the new form
            ViewImagesForm form = new ViewImagesForm(skyImagePath, starsMapPath, mythImagePath);
            //set the size of the form
            form.Size = new Size(690, 730);
            form.ShowDialog();
        }
    }
}
