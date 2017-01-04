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
using System.Text.RegularExpressions;

namespace Constellations.UI
{
    public partial class MainForm : Form
    {
        private IEnumerable<Constellation> constellations; //list to hold all constellations
        private List<string> names; //list to hold only their names

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //set the form to be maximized on any resolution
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            //set up comboBoxRepo
            InitializeComboBoxRepo();
            //set up comboBoxName with the names of all the contellations from the selected repo
            InitializeComboBoxName(RepoFactory.GetRepo(comboBoxChooseRepo.SelectedItem.ToString()));
            //set up the comboBoxSearchByHemisphere
            InitializeComboBoxSearchByHemisphere();
        }

        //method to set up the repository combo box
        private void InitializeComboBoxRepo()
        {
            //create a new binding source
            BindingSource bs = new BindingSource();
            //set the data source to be the name of each repository type
            bs.DataSource = from var in Assembly.GetExecutingAssembly().GetTypes()
                            where typeof(IConstellationData).IsAssignableFrom(var) &&
                                var.Name != "IConstellationData"
                            select var.Name;

            //set the comboBox data source to the binding source
            comboBoxChooseRepo.DataSource = bs;
        }

        //method to set up comboBoxName
        private void InitializeComboBoxName(IConstellationData info)
        {
            //get all of the constellations from the file and set them to the IEnumberable
            constellations = info.GetConstellationInfo();

            //set names to be a new list
            names = new List<string>();

            //for every constellation in the IEnumerable...
            foreach(Constellation constell in constellations)
            {
                //add the name of the constellation the "names" list
                names.Add(constell.Name);
            }

            //create a new binding source and set its data source to the "names" list
            BindingSource bs = new BindingSource();
            bs.DataSource = names;

            //set comboBoxChooseConstellations data source to the binding source
            comboBoxChooseConstellation.DataSource = bs;

            //show the label that displays the total constellations found
            labelTotalResults.Text = $"Total Results: {names.Count}";
        }

        //method for when the selected index in comboBoxChooseConstellation changes
        private void comboBoxChooseConstellation_SelectedIndexChanged(object sender, EventArgs e)
        {
            //create a list of the constellations
            List<Constellation> list = constellations.ToList();
            
            //set labelName to display the name of the currently selected constellation
            labelName.Text = comboBoxChooseConstellation.Text;

            //iterate through the list of constellations
            for(int i = 0; i < list.Count; i++)
            {
                //if the labelName text is the same as the current constellations name in the list...
                if(labelName.Text == list[i].Name)
                {
                    //set all of the labels to display information about the constellation
                    labelAbbreviation.Text = "Abbreviation: " + list[i].Abbreviation;
                    labelGenitive.Text = "Genitive: " + list[i].Genitive;
                    labelFamily.Text = "Family: " + list[i].Family;
                    labelOrigin.Text = "Origin: " + list[i].Origin;
                    labelMeaning.Text = "Meaning: " + list[i].Meaning;
                    labelBrightestStar.Text = "Brightest Star: " + list[i].BrightestStar;
                    labelHemisphere.Text = "Hemisphere: " + list[i].Hemisphere;
                    labelSeason.Text = "Season: " + list[i].Season;
                    labelBestSeen.Text = "Best Seen: " + list[i].BestSeen;
                    richTextBoxNearbyConstellations.Text = list[i].NearbyConstellations;
                    richTextBoxMythology.Text = list[i].Mythology;
                    //set pictureBoxImage to show the natural sky image from that constellation
                    pictureBoxImage.ImageLocation = list[i].ImagePathSky;
                    
                    //set i to the end of the list to stop the for loop
                    i = list.Count;
                }
            }
            //call method to set fonts and other styles for all labels and rich text boxes
            SetFontStyles();

            //set the rich text boxes to be read only so the user can't type in the boxes
            richTextBoxNearbyConstellations.ReadOnly = true;
            richTextBoxMythology.ReadOnly = true;
        }

        //method to set up font styles for each label/rich text box
        private void SetFontStyles()
        {
            Font font = new Font("Tahoma", 12);
            Font fontBold = new Font("Tahoma", 12, FontStyle.Bold);

            labelName.Font = new Font("Tahoma", 30);
            labelAbbreviation.Font = font;
            labelGenitive.Font = font;
            labelFamily.Font = font;
            labelOrigin.Font = font;
            labelMeaning.Font = font;
            labelBrightestStar.Font = font;
            labelHemisphere.Font = fontBold;
            labelSeason.Font = fontBold;
            labelBestSeen.Font = fontBold;
            labelNote.Font = new Font("Tahoma", 8);
            labelNearbyConstellations.Font = fontBold;
            labelMythology.Font = fontBold;
            richTextBoxNearbyConstellations.Font = font;
            richTextBoxMythology.Font = font;
        }

        //method for when the user clicks the View Natural Sky Image button
        private void buttonViewSkyImage_Click(object sender, EventArgs e)
        {
            //create a list to hold the constellations
            List<Constellation> list = constellations.ToList();

            //for each constellation in the list...
            for (int i = 0; i < list.Count; i++)
            {
                //if the labelName is the same as the current constellation's name in the list...
                if (labelName.Text == list[i].Name)
                {
                    //set the pictureBox to display the image of that constellation
                    pictureBoxImage.ImageLocation = list[i].ImagePathSky;
                    //set i to the end of the list to force quit the loop
                    i = list.Count;
                }
            }
        }

        //method for when the user clicks the View Star Map Image button
        private void buttonViewStars_Click(object sender, EventArgs e)
        {
            //create a list of the constellations
            List<Constellation> list = constellations.ToList();

            //for each constellation in the list...
            for (int i = 0; i < list.Count; i++)
            {
                //if the labelName is the same as the current constellation's name in the list...
                if (labelName.Text == list[i].Name)
                {
                    //set the pictureBox to display the image of that constellation
                    pictureBoxImage.ImageLocation = list[i].ImagePathStars;
                    //set i to the end of the list to force quit the loop
                    i = list.Count;
                }
            }
        }

        //method for when the user clicks on the View Mythology Image button
        private void buttonViewMythologyImage_Click(object sender, EventArgs e)
        {
            //create a list of the constellations
            List<Constellation> list = constellations.ToList();

            //for each constellation in the list...
            for(int i = 0; i < list.Count; i++)
            {
                //if the labelName is the same as the current constellation's name in the list
                if(labelName.Text == list[i].Name)
                {
                    //set the pictureBox to display the image of that constellation
                    pictureBoxImage.ImageLocation = list[i].ImagePathPicture;
                    //set i to the end of the listto force quit the loop
                    i = list.Count;
                }
            }
        }

        //method for when the user clicks the Advanced Search button
        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            //create a new binding source
            BindingSource bsHemisphere = new BindingSource();
            //set its data source to contain each hemisphere in the list
            bsHemisphere.DataSource = from constell in constellations       //for each constellation
                                      group constell by constell.Hemisphere //group the constellations by hemisphere
                                      into c
                                      select c.First().Hemisphere;          //select the first instance of each unique hemisphere

            //create a new binding source
            BindingSource bsMonth = new BindingSource();
            //set its data source to contain each best seen option (month) in the list
            bsMonth.DataSource = from constell in constellations     //for each constellation
                                 group constell by constell.BestSeen //group the constellations by best seen
                                 into c
                                 select c.First().BestSeen;          //select the first instance of each unique best seen option

            //create and display the advanced search form
            AdvancedSearchForm form = new AdvancedSearchForm(bsHemisphere, bsMonth);
            form.ShowDialog();
        }

        //method for when the user clicks the Search By Letter button
        private void buttonSearchLetter_Click(object sender, EventArgs e)
        {
            //variable to hold the letter entered
            string letter = "";

            //if the letter entered is a valid latter...
            if (textBoxFindLetter.Text.Length == 1 && Regex.IsMatch(textBoxFindLetter.Text, @"^[a-zA-Z]+$"))
            {
                //set the text to the variable
                letter = textBoxFindLetter.Text;

                //array to hold each letter of the constellation's name
                char[] array;
                //list to hold the results
                List<string> matchingNames = new List<string>();
                
                //for each name in the list...
                for(int i = 0; i < names.Count; i++)
                {
                    //split the name into a char array
                    array = names[i].ToCharArray();
                    
                    //if the first item in the char array is the same as the entered letter...
                    if(array[0].ToString().Equals(letter))
                    {
                        //add the name to the list of results
                        matchingNames.Add(names[i]);
                    }
                }

                //create a new binding source
                BindingSource bs = new BindingSource();
                //set the data source to the list of results
                bs.DataSource = matchingNames;
                //set the comboBoxChooseConstellation data source to the binding source
                comboBoxChooseConstellation.DataSource = bs;

                //set the total results label
                labelTotalResults.Text = $"Total Results: {bs.Count}";

                //if there were no results...
                if(bs.Count == 0)
                {
                    //display a message
                    MessageBox.Show("No results");
                    //reset the selected index
                    comboBoxChooseConstellation.SelectedIndex = -1;
                }
            }

            //otherwise the user input is invalid
            else
            {
                //display a message
                MessageBox.Show("Invalid Entry");
            }

            //change the selected index of the comboBoxSearchByHemisphere
            comboBoxSearchByHemisphere.SelectedIndex = -1;
        }

        //method for when the user clicks the Show All Constellations button
        private void buttonShowAllConstellations_Click(object sender, EventArgs e)
        {
            //create a new binding source
            BindingSource bs = new BindingSource();
            //set it to the list of names
            bs.DataSource = names;
            //set the comboBoxChooseConstellation data source to the binding source
            comboBoxChooseConstellation.DataSource = bs;

            //reset the textBoxFindLetter and comboBoxSearchByHemisphere
            textBoxFindLetter.Text = "";
            comboBoxSearchByHemisphere.SelectedIndex = -1;

            //reset the total results label
            labelTotalResults.Text = $"Total Results: {bs.Count}";
        }

        //method to set up the search by hemisphere combo box
        private void InitializeComboBoxSearchByHemisphere()
        {
            //create a list of the constellations
            List<Constellation> list = constellations.ToList();

            //create a new binding source
            BindingSource bs = new BindingSource();
            //set its data source to contain each unique hemisphere
            bs.DataSource = from constell in list                   //for each constellation
                            group constell by constell.Hemisphere   //group the constellations by hemispheres
                            into c
                            select c.First().Hemisphere;            //select the first instance of each unique hemisphere

            //set the combo box data source to the binding source
            comboBoxSearchByHemisphere.DataSource = bs;

            //set the first cell on load to be empty
            comboBoxSearchByHemisphere.SelectedIndex = -1; 
        }

        private void comboBoxSearchByHemisphere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        //method for when the user clicks the Search By Hemisphere button
        private void buttonSearchByHemisphere_Click(object sender, EventArgs e)
        {
            //set the selected item in the combo box to a variable
            string hemisphere = comboBoxSearchByHemisphere.SelectedItem.ToString();

            //create a new binding source
            BindingSource bs = new BindingSource();
            //set its data source to contain each contellation name that's in the selected hemisphere
            bs.DataSource = from constell in constellations              //for each constellation
                            where constell.Hemisphere.Equals(hemisphere) //that contains the selected hemisphere
                            select constell.Name;                        //select that constellation's name

            //set the combo box data source to the binding source
            comboBoxChooseConstellation.DataSource = bs;

            //update the total results label
            labelTotalResults.Text = $"Total Results: {bs.Count}";

            //reset the text box for searching by letter
            textBoxFindLetter.Text = null;
        }
    }
}
