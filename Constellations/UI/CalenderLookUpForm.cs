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
    public partial class CalenderLookUpForm : Form
    {
        private IEnumerable<Constellation> constellations;

        public CalenderLookUpForm(BindingSource bsHemisphere, BindingSource bsMonth)
        {
            InitializeComponent();

            InitializeComboBoxChooseRepo();
            InitializeComboBoxSelectHemisphere(bsHemisphere);
            InitializeComboBoxSelectMonth(bsMonth);

            labelSelectMonth.Hide();
            comboBoxSelectMonth.Hide();
            buttonSearch.Hide();
            listBoxResults.Hide();
        }

        private void CalenderLookUpForm_Load(object sender, EventArgs e)
        {
            InitializeConstellations(RepoFactory.GetRepo(comboBoxChooseRepo.SelectedItem.ToString()));
        }

        private void InitializeComboBoxChooseRepo()
        {
            BindingSource bs = new BindingSource();

            bs.DataSource = from var in Assembly.GetExecutingAssembly().GetTypes()
                            where typeof(IConstellationData).IsAssignableFrom(var) &&
                                var.Name != "IConstellationData"
                            select var.Name;

            comboBoxChooseRepo.DataSource = bs;
        }

        private void InitializeConstellations(IConstellationData info)
        {
            constellations = info.GetConstellationInfo();
        }

        private void InitializeComboBoxSelectHemisphere(BindingSource bsHemp)
        {
            comboBoxSelectHemisphere.DataSource = bsHemp;
            comboBoxSelectHemisphere.SelectedIndex = -1;
        }

        private void InitializeComboBoxSelectMonth(BindingSource bsMonth)
        {
            comboBoxSelectMonth.DataSource = bsMonth;
        }

        private void comboBoxSelectHemisphere_SelectedIndexChanged(object sender, EventArgs e)
        {
            string hemisphere = "";

            if (comboBoxSelectHemisphere.SelectedIndex != -1)
            {
                hemisphere = comboBoxSelectHemisphere.SelectedItem.ToString();

                //change the comboBoxSelectMonth options based on the chosen hemisphere
                List<Constellation> list = constellations.ToList();
                List<Constellation> results = new List<Constellation>();

                foreach(Constellation constell in list)
                {
                    if (constell.Hemisphere.Equals(hemisphere))
                    {
                        results.Add(constell);
                    }
                }

                string month = "";
                List<string> allMonths = new List<string>();
                bool match = false; 

                foreach(Constellation constell in results)
                {
                    month = constell.BestSeen;
                    if (!allMonths.Contains(month))
                    {
                        allMonths.Add(month);
                    }
                }

                var sortedMonths = allMonths
                    .Select(m => new { Name = m, Sort = DateTime.ParseExact(m, "MMMM", CultureInfo.InvariantCulture) })
                    .OrderBy(m => m.Sort.Month)
                    .Select(m => m.Name);

                BindingSource bs = new BindingSource();
                bs.DataSource = sortedMonths;

                comboBoxSelectMonth.DataSource = bs;

                labelSelectMonth.Show();
                comboBoxSelectMonth.Show();
                comboBoxSelectMonth.SelectedIndex = -1;
                buttonSearch.Hide();
                listBoxResults.Hide();
                labelTotalResults.Hide();
            }
        }

        private void comboBoxSelectMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSelectMonth.SelectedIndex != -1)
            {
                buttonSearch.Show();
                listBoxResults.Hide();
                labelTotalResults.Hide();
                
            }
        }

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
                listBoxResults.SelectedIndex = -1;

                labelTotalResults.Text = $"Total Results: {bsResults.Count}";
                labelTotalResults.Show();

                //try to set up a tooltip when you hover over an item in the list box
                //have it show its meaning
                toolTip1.SetToolTip(listBoxResults, "Boop");

                if (bsResults.Count > 0)
                {
                    listBoxResults.Show();
                }
                else
                {
                    MessageBox.Show("No results");
                }
            }
        }
    }
}
