namespace Constellations.UI
{
    partial class PrintPreviewForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
            this.printDocumentConstellation = new System.Drawing.Printing.PrintDocument();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.printPreviewDialogConstellation = new System.Windows.Forms.PrintPreviewDialog();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelGenitive = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.labelBrightestStar = new System.Windows.Forms.Label();
            this.labelHemisphere = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.labelBestSeen = new System.Windows.Forms.Label();
            this.labelNearbyConstellations = new System.Windows.Forms.Label();
            this.labelNearbyList = new System.Windows.Forms.Label();
            this.labelMythology = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonViewSky = new System.Windows.Forms.Button();
            this.buttonViewStars = new System.Windows.Forms.Button();
            this.buttonViewMyth = new System.Windows.Forms.Button();
            this.richTextBoxMyth = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // printDocumentConstellation
            // 
            this.printDocumentConstellation.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentConstellation_PrintPage);
            // 
            // buttonPrint
            // 
            this.buttonPrint.Location = new System.Drawing.Point(519, 12);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(75, 23);
            this.buttonPrint.TabIndex = 0;
            this.buttonPrint.Text = "Print";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(28, 21);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Name";
            // 
            // printPreviewDialogConstellation
            // 
            this.printPreviewDialogConstellation.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialogConstellation.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialogConstellation.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialogConstellation.Document = this.printDocumentConstellation;
            this.printPreviewDialogConstellation.Enabled = true;
            this.printPreviewDialogConstellation.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialogConstellation.Icon")));
            this.printPreviewDialogConstellation.Name = "printPreviewDialogConstellation";
            this.printPreviewDialogConstellation.Visible = false;
            this.printPreviewDialogConstellation.Load += new System.EventHandler(this.printPreviewDialogConstellation_Load);
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Location = new System.Drawing.Point(53, 82);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(66, 13);
            this.labelAbbreviation.TabIndex = 2;
            this.labelAbbreviation.Text = "Abbreviation";
            // 
            // labelGenitive
            // 
            this.labelGenitive.AutoSize = true;
            this.labelGenitive.Location = new System.Drawing.Point(53, 113);
            this.labelGenitive.Name = "labelGenitive";
            this.labelGenitive.Size = new System.Drawing.Size(46, 13);
            this.labelGenitive.TabIndex = 3;
            this.labelGenitive.Text = "Genitive";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(53, 144);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(36, 13);
            this.labelFamily.TabIndex = 4;
            this.labelFamily.Text = "Family";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(53, 175);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(34, 13);
            this.labelOrigin.TabIndex = 5;
            this.labelOrigin.Text = "Origin";
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Location = new System.Drawing.Point(53, 206);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(48, 13);
            this.labelMeaning.TabIndex = 6;
            this.labelMeaning.Text = "Meaning";
            // 
            // labelBrightestStar
            // 
            this.labelBrightestStar.AutoSize = true;
            this.labelBrightestStar.Location = new System.Drawing.Point(53, 237);
            this.labelBrightestStar.Name = "labelBrightestStar";
            this.labelBrightestStar.Size = new System.Drawing.Size(70, 13);
            this.labelBrightestStar.TabIndex = 7;
            this.labelBrightestStar.Text = "Brightest Star";
            // 
            // labelHemisphere
            // 
            this.labelHemisphere.AutoSize = true;
            this.labelHemisphere.Location = new System.Drawing.Point(53, 268);
            this.labelHemisphere.Name = "labelHemisphere";
            this.labelHemisphere.Size = new System.Drawing.Size(63, 13);
            this.labelHemisphere.TabIndex = 8;
            this.labelHemisphere.Text = "Hemisphere";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(53, 299);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(43, 13);
            this.labelSeason.TabIndex = 9;
            this.labelSeason.Text = "Season";
            // 
            // labelBestSeen
            // 
            this.labelBestSeen.AutoSize = true;
            this.labelBestSeen.Location = new System.Drawing.Point(53, 330);
            this.labelBestSeen.Name = "labelBestSeen";
            this.labelBestSeen.Size = new System.Drawing.Size(56, 13);
            this.labelBestSeen.TabIndex = 10;
            this.labelBestSeen.Text = "Best Seen";
            // 
            // labelNearbyConstellations
            // 
            this.labelNearbyConstellations.AutoSize = true;
            this.labelNearbyConstellations.Location = new System.Drawing.Point(53, 361);
            this.labelNearbyConstellations.Name = "labelNearbyConstellations";
            this.labelNearbyConstellations.Size = new System.Drawing.Size(109, 13);
            this.labelNearbyConstellations.TabIndex = 11;
            this.labelNearbyConstellations.Text = "Nearby Constellations";
            // 
            // labelNearbyList
            // 
            this.labelNearbyList.AutoSize = true;
            this.labelNearbyList.Location = new System.Drawing.Point(88, 390);
            this.labelNearbyList.Name = "labelNearbyList";
            this.labelNearbyList.Size = new System.Drawing.Size(60, 13);
            this.labelNearbyList.TabIndex = 12;
            this.labelNearbyList.Text = "Nearby List";
            // 
            // labelMythology
            // 
            this.labelMythology.AutoSize = true;
            this.labelMythology.Location = new System.Drawing.Point(565, 82);
            this.labelMythology.Name = "labelMythology";
            this.labelMythology.Size = new System.Drawing.Size(55, 13);
            this.labelMythology.TabIndex = 13;
            this.labelMythology.Text = "Mythology";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(641, 349);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(206, 198);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImage.TabIndex = 15;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonViewSky
            // 
            this.buttonViewSky.Location = new System.Drawing.Point(565, 294);
            this.buttonViewSky.Name = "buttonViewSky";
            this.buttonViewSky.Size = new System.Drawing.Size(137, 23);
            this.buttonViewSky.TabIndex = 16;
            this.buttonViewSky.Text = "View Natural Sky Image";
            this.buttonViewSky.UseVisualStyleBackColor = true;
            // 
            // buttonViewStars
            // 
            this.buttonViewStars.Location = new System.Drawing.Point(708, 294);
            this.buttonViewStars.Name = "buttonViewStars";
            this.buttonViewStars.Size = new System.Drawing.Size(92, 23);
            this.buttonViewStars.TabIndex = 17;
            this.buttonViewStars.Text = "View Star Map";
            this.buttonViewStars.UseVisualStyleBackColor = true;
            // 
            // buttonViewMyth
            // 
            this.buttonViewMyth.Location = new System.Drawing.Point(806, 294);
            this.buttonViewMyth.Name = "buttonViewMyth";
            this.buttonViewMyth.Size = new System.Drawing.Size(133, 23);
            this.buttonViewMyth.TabIndex = 18;
            this.buttonViewMyth.Text = "View Mythology Image";
            this.buttonViewMyth.UseVisualStyleBackColor = true;
            // 
            // richTextBoxMyth
            // 
            this.richTextBoxMyth.Location = new System.Drawing.Point(568, 98);
            this.richTextBoxMyth.Name = "richTextBoxMyth";
            this.richTextBoxMyth.Size = new System.Drawing.Size(371, 190);
            this.richTextBoxMyth.TabIndex = 19;
            this.richTextBoxMyth.Text = "";
            // 
            // PrintPreviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.richTextBoxMyth);
            this.Controls.Add(this.buttonViewMyth);
            this.Controls.Add(this.buttonViewStars);
            this.Controls.Add(this.buttonViewSky);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelMythology);
            this.Controls.Add(this.labelNearbyList);
            this.Controls.Add(this.labelNearbyConstellations);
            this.Controls.Add(this.labelBestSeen);
            this.Controls.Add(this.labelSeason);
            this.Controls.Add(this.labelHemisphere);
            this.Controls.Add(this.labelBrightestStar);
            this.Controls.Add(this.labelMeaning);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.labelGenitive);
            this.Controls.Add(this.labelAbbreviation);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonPrint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PrintPreviewForm";
            this.Text = "PrintPreviewForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Drawing.Printing.PrintDocument printDocumentConstellation;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialogConstellation;
        private System.Windows.Forms.Label labelAbbreviation;
        private System.Windows.Forms.Label labelGenitive;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelMeaning;
        private System.Windows.Forms.Label labelBrightestStar;
        private System.Windows.Forms.Label labelHemisphere;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.Label labelBestSeen;
        private System.Windows.Forms.Label labelNearbyConstellations;
        private System.Windows.Forms.Label labelNearbyList;
        private System.Windows.Forms.Label labelMythology;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonViewSky;
        private System.Windows.Forms.Button buttonViewStars;
        private System.Windows.Forms.Button buttonViewMyth;
        private System.Windows.Forms.RichTextBox richTextBoxMyth;
    }
}