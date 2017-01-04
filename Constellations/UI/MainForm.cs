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
        private IEnumerable<Constellation> constellations;
        private List<string> names;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            InitializeComboBoxRepo();
            InitializeComboBoxName(RepoFactory.GetRepo(comboBoxChooseRepo.SelectedItem.ToString()));
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

            comboBoxChooseRepo.DataSource = bs;
        }

        private void InitializeComboBoxName(IConstellationData info)
        {
            constellations = info.GetConstellationInfo();

            names = new List<string>();

            foreach(Constellation constell in constellations)
            {
                names.Add(constell.Name);
            }

            BindingSource bs = new BindingSource();
            bs.DataSource = names;

            comboBoxChooseConstellation.DataSource = bs;

            labelTotalResults.Text = $"Total Results: {names.Count}";
        }

        private void comboBoxChooseConstellation_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Constellation> list = constellations.ToList();
            labelName.Font = new Font("Tahoma", 30);
            labelName.Text = comboBoxChooseConstellation.Text;
            for(int i = 0; i < list.Count; i++)
            {
                if(labelName.Text == list[i].Name)
                {
                    labelAbbreviation.Text = "Abbreviation: " + list[i].Abbreviation;
                    //set the rest of the labels to display information
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

                    pictureBoxImage.ImageLocation = list[i].ImagePathSky;
                    
                    i = list.Count;
                }
            }
            //set fonts and other styles here
            Font font = new Font("Tahoma", 12);
            Font fontBold = new Font("Tahoma", 12, FontStyle.Bold);
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

            richTextBoxNearbyConstellations.ReadOnly = true;
            richTextBoxMythology.ReadOnly = true;
        }

        private void buttonViewSkyImage_Click(object sender, EventArgs e)
        {
            List<Constellation> list = constellations.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (labelName.Text == list[i].Name)
                {
                    pictureBoxImage.ImageLocation = list[i].ImagePathSky;
                    i = list.Count;
                }
            }
        }

        private void buttonViewStars_Click(object sender, EventArgs e)
        {
            List<Constellation> list = constellations.ToList();
            for (int i = 0; i < list.Count; i++)
            {
                if (labelName.Text == list[i].Name)
                {
                    pictureBoxImage.ImageLocation = list[i].ImagePathStars;
                    i = list.Count;
                }
            }
        }

        private void buttonViewMythologyImage_Click(object sender, EventArgs e)
        {
            List<Constellation> list = constellations.ToList();
            for(int i = 0; i < list.Count; i++)
            {
                if(labelName.Text == list[i].Name)
                {
                    pictureBoxImage.ImageLocation = list[i].ImagePathPicture;
                    i = list.Count;
                }
            }
        }

        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            BindingSource bsHemisphere = new BindingSource();
            bsHemisphere.DataSource = from constell in constellations
                                      group constell by constell.Hemisphere
                                      into c
                                      select c.First().Hemisphere;

            BindingSource bsMonth = new BindingSource();
            bsMonth.DataSource = from constell in constellations
                                 group constell by constell.BestSeen
                                 into c
                                 select c.First().BestSeen;

            /*BindingSource bsConstellations = new BindingSource();
            bsConstellations.DataSource = from constell in constellations
                                          select constell;*/


            AdvancedSearchForm form = new AdvancedSearchForm(bsHemisphere, bsMonth);
            form.ShowDialog();
        }

        private void buttonSearchLetter_Click(object sender, EventArgs e)
        {
            string letter = "";

            if (textBoxFindLetter.Text.Length == 1 && Regex.IsMatch(textBoxFindLetter.Text, @"^[a-zA-Z]+$"))
            {
                letter = textBoxFindLetter.Text;
                //set it up so the drop down menu only shows constellation names 
                //starting with the entered letter
                List<Constellation> list = constellations.ToList();
                char[] array;
                List<string> matchingNames = new List<string>();
                
                for(int i = 0; i < names.Count; i++)
                {
                    array = names[i].ToCharArray();
                    
                    if(array[0].ToString().Equals(letter))
                    {
                        matchingNames.Add(names[i]);
                    }
                }

                BindingSource bs = new BindingSource();
                bs.DataSource = matchingNames;
                comboBoxChooseConstellation.DataSource = bs;

                labelTotalResults.Text = $"Total Results: {bs.Count}";

                if(bs.Count == 0)
                {
                    MessageBox.Show("No results");
                    comboBoxChooseConstellation.SelectedIndex = -1;
                }
            }
            
            else
            {
                MessageBox.Show("Invalid Entry");
            }

            comboBoxSearchByHemisphere.SelectedIndex = -1;
        }

        private void buttonShowAllConstellations_Click(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = names;
            comboBoxChooseConstellation.DataSource = bs;

            textBoxFindLetter.Text = "";
            comboBoxSearchByHemisphere.SelectedIndex = -1;

            labelTotalResults.Text = $"Total Results: {bs.Count}";
        }

        private void InitializeComboBoxSearchByHemisphere()
        {
            List<Constellation> list = new List<Constellation>();
            list = constellations.ToList();

            BindingSource bs = new BindingSource();
            bs.DataSource = from constell in list
                            group constell by constell.Hemisphere
                            into c
                            select c.First().Hemisphere;

            comboBoxSearchByHemisphere.DataSource = bs;
            comboBoxSearchByHemisphere.SelectedIndex = -1; //set the first cell on load to be empty
        }

        private void comboBoxSearchByHemisphere_SelectedIndexChanged(object sender, EventArgs e)
        {
            //textBoxFindLetter.Text = null;
        }

        private void buttonSearchByHemisphere_Click(object sender, EventArgs e)
        {
            string hemisphere = comboBoxSearchByHemisphere.SelectedItem.ToString();

            BindingSource bs = new BindingSource();
            bs.DataSource = from constell in constellations
                            where constell.Hemisphere.Equals(hemisphere)
                            select constell.Name;

            comboBoxChooseConstellation.DataSource = bs;
            labelTotalResults.Text = $"Total Results: {bs.Count}";

            textBoxFindLetter.Text = null;
        }
    }
}
