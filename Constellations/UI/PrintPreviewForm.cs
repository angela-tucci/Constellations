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
using System.Drawing.Printing;
using System.IO;

namespace Constellations.UI
{
    public partial class PrintPreviewForm : Form
    {
        public PrintPreviewForm(Constellation constellation)
        {
            InitializeComponent();

            SetUpForm(constellation);
        }

        private void SetUpForm(Constellation constellation)
        {
            //set the form to be maximized on any resolution
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            labelName.Text = constellation.Name;
            labelAbbreviation.Text = constellation.Abbreviation;
            labelGenitive.Text = constellation.Genitive;
            labelFamily.Text = constellation.Family;
            labelOrigin.Text = constellation.Origin;
            labelMeaning.Text = constellation.Meaning;
            labelBrightestStar.Text = constellation.BrightestStar;
            labelHemisphere.Text = constellation.Hemisphere;
            labelSeason.Text = constellation.Season;
            labelBestSeen.Text = constellation.BestSeen;
            labelNearbyList.Text = constellation.NearbyConstellations;
            richTextBoxMyth.Text = constellation.Mythology;

            Font font = new Font("Tahoma", 12);
            labelName.Font = new Font("Tahoma", 30);
            labelAbbreviation.Font = font;
            labelGenitive.Font = font;
            labelFamily.Font = font;
            labelOrigin.Font = font;
            labelMeaning.Font = font;
            labelBrightestStar.Font = font;
            labelHemisphere.Font = font;
            labelSeason.Font = font;
            labelBestSeen.Font = font;
            labelNearbyConstellations.Font = font;
            labelNearbyList.Font = font;
            labelMythology.Font = font;
            

            pictureBoxImage.ImageLocation = constellation.ImagePathSky;
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            buttonPrint.Hide();
            buttonViewSky.Hide();
            buttonViewStars.Hide();
            buttonViewMyth.Hide();

            PrintScreen();
            printPreviewDialogConstellation.ShowDialog();
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        public static extern long BitBlt(IntPtr hdcDest, int nXDest, int nYDest, int nWidth, int nHeight, IntPtr hdcSrc, int nXSrc, int nYSrc, int dwRop);
        private Bitmap memoryImage;

        private void PrintScreen()
        {
            Graphics mygraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, mygraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            IntPtr dc1 = mygraphics.GetHdc();
            IntPtr dc2 = memoryGraphics.GetHdc();
            BitBlt(dc2, 0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height, dc1, 0, 0, 13369376);
            mygraphics.ReleaseHdc(dc1);
            memoryGraphics.ReleaseHdc(dc2);
        }

        //who knows if this works?
        private void printDocumentConstellation_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);

            
            buttonPrint.Show();
            /*int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);*/


            //e.Graphics.CopyFromScreen(this.Height, this.Width, this.Size);
            //e.Graphics.DrawString(this.labelName.Text, this.labelName.Font, Brushes.Black, 10, 25);
            //e.Graphics.DrawString(this.labelAbbreviation.Text, this.labelAbbreviation.Font, Brushes.Black, 10, 25);
        }

        private void printPreviewDialogConstellation_Load(object sender, EventArgs e)
        {

        }
    }
}
