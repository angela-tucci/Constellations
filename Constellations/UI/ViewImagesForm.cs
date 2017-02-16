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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Constellations.Model;
using Constellations.Data;

namespace Constellations.UI
{
    public partial class ViewImagesForm : Form
    {
        //variables that hold each image path
        private string skyPath;
        private string starsPath;
        private string mythPath;
        
        public ViewImagesForm(string skyImagePath, string starsMapPath, string mythImagePath)
        {
            InitializeComponent();

            //call method to set up the form
            SetUp(skyImagePath, starsMapPath, mythImagePath);
        }

        //method to set up the initial form
        private void SetUp(string skyImagePath, string starsMapPath, string mythImagePath)
        {
            //set the values to the image paths
            skyPath = skyImagePath;
            starsPath = starsMapPath;
            mythPath = mythImagePath;

            //set the initial image to the picture box
            pictureBoxImage.ImageLocation = skyImagePath;
            //CenterImage();
        }

        //method for when the user clicks the View Natural Sky Image
        private void buttonViewSky_Click(object sender, EventArgs e)
        {
            //change the image in the picture box
            pictureBoxImage.ImageLocation = skyPath;
            //CenterImage();
        }

        //method for when the user clicks the View Star Map Image button
        private void buttonViewStarMap_Click(object sender, EventArgs e)
        {
            //change the image in the picture box
            pictureBoxImage.ImageLocation = starsPath;
            //CenterImage();
        }

        //method for when the user clicks the View Mythology Image button
        private void buttonViewMyth_Click(object sender, EventArgs e)
        {
            //change the image in the picture box
            pictureBoxImage.ImageLocation = mythPath;
           // CenterImage();
        }

        //method to center the image, currently doesn't work the way I want it to
        private void CenterImage()
        {
            pictureBoxImage.Location = new Point((pictureBoxImage.Parent.ClientSize.Width / 2) -
                (pictureBoxImage.Width / 2), (pictureBoxImage.Parent.ClientSize.Height / 2) -
                (pictureBoxImage.Height / 2));
        }
    }
}
