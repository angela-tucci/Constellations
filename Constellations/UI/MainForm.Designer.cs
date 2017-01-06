namespace Constellations.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.comboBoxChooseConstellation = new System.Windows.Forms.ComboBox();
            this.labelChooseConstellation = new System.Windows.Forms.Label();
            this.comboBoxChooseRepo = new System.Windows.Forms.ComboBox();
            this.labelChooseRepo = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelGenitive = new System.Windows.Forms.Label();
            this.buttonViewStars = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonViewMythologyImage = new System.Windows.Forms.Button();
            this.buttonViewSkyImage = new System.Windows.Forms.Button();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.labelBrightestStar = new System.Windows.Forms.Label();
            this.labelHemisphere = new System.Windows.Forms.Label();
            this.labelBestSeen = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelSeason = new System.Windows.Forms.Label();
            this.richTextBoxMythology = new System.Windows.Forms.RichTextBox();
            this.labelMythology = new System.Windows.Forms.Label();
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.labelNearbyConstellations = new System.Windows.Forms.Label();
            this.richTextBoxNearbyConstellations = new System.Windows.Forms.RichTextBox();
            this.textBoxFindLetter = new System.Windows.Forms.TextBox();
            this.buttonSearchLetter = new System.Windows.Forms.Button();
            this.buttonShowAllConstellations = new System.Windows.Forms.Button();
            this.labelSearchByLetter = new System.Windows.Forms.Label();
            this.labelSearchByHemisphere = new System.Windows.Forms.Label();
            this.comboBoxSearchByHemisphere = new System.Windows.Forms.ComboBox();
            this.buttonSearchByHemisphere = new System.Windows.Forms.Button();
            this.labelTotalResults = new System.Windows.Forms.Label();
            this.labelSearchByFamily = new System.Windows.Forms.Label();
            this.comboBoxSearchByFamily = new System.Windows.Forms.ComboBox();
            this.buttonSearchByFamily = new System.Windows.Forms.Button();
            this.labelSearchByOrigin = new System.Windows.Forms.Label();
            this.comboBoxSearchByOrigin = new System.Windows.Forms.ComboBox();
            this.buttonSearchByOrigin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChooseConstellation
            // 
            this.comboBoxChooseConstellation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseConstellation.FormattingEnabled = true;
            this.comboBoxChooseConstellation.Location = new System.Drawing.Point(12, 511);
            this.comboBoxChooseConstellation.Name = "comboBoxChooseConstellation";
            this.comboBoxChooseConstellation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseConstellation.TabIndex = 0;
            this.comboBoxChooseConstellation.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseConstellation_SelectedIndexChanged);
            // 
            // labelChooseConstellation
            // 
            this.labelChooseConstellation.AutoSize = true;
            this.labelChooseConstellation.Location = new System.Drawing.Point(12, 486);
            this.labelChooseConstellation.Name = "labelChooseConstellation";
            this.labelChooseConstellation.Size = new System.Drawing.Size(115, 13);
            this.labelChooseConstellation.TabIndex = 1;
            this.labelChooseConstellation.Text = "Choose a Constellation";
            // 
            // comboBoxChooseRepo
            // 
            this.comboBoxChooseRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseRepo.FormattingEnabled = true;
            this.comboBoxChooseRepo.Location = new System.Drawing.Point(12, 47);
            this.comboBoxChooseRepo.Name = "comboBoxChooseRepo";
            this.comboBoxChooseRepo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseRepo.TabIndex = 2;
            // 
            // labelChooseRepo
            // 
            this.labelChooseRepo.AutoSize = true;
            this.labelChooseRepo.Location = new System.Drawing.Point(12, 22);
            this.labelChooseRepo.Name = "labelChooseRepo";
            this.labelChooseRepo.Size = new System.Drawing.Size(96, 13);
            this.labelChooseRepo.TabIndex = 3;
            this.labelChooseRepo.Text = "Choose Repository";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(204, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 4;
            this.labelName.Text = "Name";
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Location = new System.Drawing.Point(24, 7);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(66, 13);
            this.labelAbbreviation.TabIndex = 5;
            this.labelAbbreviation.Text = "Abbreviation";
            // 
            // labelGenitive
            // 
            this.labelGenitive.AutoSize = true;
            this.labelGenitive.Location = new System.Drawing.Point(24, 34);
            this.labelGenitive.Name = "labelGenitive";
            this.labelGenitive.Size = new System.Drawing.Size(46, 13);
            this.labelGenitive.TabIndex = 6;
            this.labelGenitive.Text = "Genitive";
            // 
            // buttonViewStars
            // 
            this.buttonViewStars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewStars.Location = new System.Drawing.Point(830, 12);
            this.buttonViewStars.Name = "buttonViewStars";
            this.buttonViewStars.Size = new System.Drawing.Size(131, 23);
            this.buttonViewStars.TabIndex = 7;
            this.buttonViewStars.Text = "View Star Map Image";
            this.buttonViewStars.UseVisualStyleBackColor = true;
            this.buttonViewStars.Click += new System.EventHandler(this.buttonViewStars_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(607, 56);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(100, 130);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImage.TabIndex = 8;
            this.pictureBoxImage.TabStop = false;
            // 
            // buttonViewMythologyImage
            // 
            this.buttonViewMythologyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewMythologyImage.Location = new System.Drawing.Point(1001, 12);
            this.buttonViewMythologyImage.Name = "buttonViewMythologyImage";
            this.buttonViewMythologyImage.Size = new System.Drawing.Size(152, 23);
            this.buttonViewMythologyImage.TabIndex = 9;
            this.buttonViewMythologyImage.Text = "View Mythology Image";
            this.buttonViewMythologyImage.UseVisualStyleBackColor = true;
            this.buttonViewMythologyImage.Click += new System.EventHandler(this.buttonViewMythologyImage_Click);
            // 
            // buttonViewSkyImage
            // 
            this.buttonViewSkyImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewSkyImage.Location = new System.Drawing.Point(607, 12);
            this.buttonViewSkyImage.Name = "buttonViewSkyImage";
            this.buttonViewSkyImage.Size = new System.Drawing.Size(176, 23);
            this.buttonViewSkyImage.TabIndex = 10;
            this.buttonViewSkyImage.Text = "View Natural Sky Image";
            this.buttonViewSkyImage.UseVisualStyleBackColor = true;
            this.buttonViewSkyImage.Click += new System.EventHandler(this.buttonViewSkyImage_Click);
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(24, 61);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(36, 13);
            this.labelFamily.TabIndex = 11;
            this.labelFamily.Text = "Family";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(24, 88);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(34, 13);
            this.labelOrigin.TabIndex = 12;
            this.labelOrigin.Text = "Origin";
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Location = new System.Drawing.Point(24, 115);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(48, 13);
            this.labelMeaning.TabIndex = 13;
            this.labelMeaning.Text = "Meaning";
            // 
            // labelBrightestStar
            // 
            this.labelBrightestStar.AutoSize = true;
            this.labelBrightestStar.Location = new System.Drawing.Point(24, 142);
            this.labelBrightestStar.Name = "labelBrightestStar";
            this.labelBrightestStar.Size = new System.Drawing.Size(70, 13);
            this.labelBrightestStar.TabIndex = 14;
            this.labelBrightestStar.Text = "Brightest Star";
            // 
            // labelHemisphere
            // 
            this.labelHemisphere.AutoSize = true;
            this.labelHemisphere.Location = new System.Drawing.Point(24, 186);
            this.labelHemisphere.Name = "labelHemisphere";
            this.labelHemisphere.Size = new System.Drawing.Size(63, 13);
            this.labelHemisphere.TabIndex = 15;
            this.labelHemisphere.Text = "Hemisphere";
            // 
            // labelBestSeen
            // 
            this.labelBestSeen.AutoSize = true;
            this.labelBestSeen.Location = new System.Drawing.Point(24, 240);
            this.labelBestSeen.Name = "labelBestSeen";
            this.labelBestSeen.Size = new System.Drawing.Size(56, 13);
            this.labelBestSeen.TabIndex = 16;
            this.labelBestSeen.Text = "Best Seen";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNote);
            this.panel1.Controls.Add(this.labelSeason);
            this.panel1.Controls.Add(this.labelAbbreviation);
            this.panel1.Controls.Add(this.labelBestSeen);
            this.panel1.Controls.Add(this.labelGenitive);
            this.panel1.Controls.Add(this.labelHemisphere);
            this.panel1.Controls.Add(this.labelFamily);
            this.panel1.Controls.Add(this.labelBrightestStar);
            this.panel1.Controls.Add(this.labelOrigin);
            this.panel1.Controls.Add(this.labelMeaning);
            this.panel1.Location = new System.Drawing.Point(181, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 287);
            this.panel1.TabIndex = 17;
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Location = new System.Drawing.Point(24, 265);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(246, 13);
            this.labelNote.TabIndex = 18;
            this.labelNote.Text = "(Note: All constellations are best seen at 9:00 p.m.)";
            // 
            // labelSeason
            // 
            this.labelSeason.AutoSize = true;
            this.labelSeason.Location = new System.Drawing.Point(24, 213);
            this.labelSeason.Name = "labelSeason";
            this.labelSeason.Size = new System.Drawing.Size(43, 13);
            this.labelSeason.TabIndex = 17;
            this.labelSeason.Text = "Season";
            // 
            // richTextBoxMythology
            // 
            this.richTextBoxMythology.Location = new System.Drawing.Point(208, 476);
            this.richTextBoxMythology.Name = "richTextBoxMythology";
            this.richTextBoxMythology.ReadOnly = true;
            this.richTextBoxMythology.Size = new System.Drawing.Size(309, 196);
            this.richTextBoxMythology.TabIndex = 18;
            this.richTextBoxMythology.Text = "";
            // 
            // labelMythology
            // 
            this.labelMythology.AutoSize = true;
            this.labelMythology.Location = new System.Drawing.Point(208, 451);
            this.labelMythology.Name = "labelMythology";
            this.labelMythology.Size = new System.Drawing.Size(55, 13);
            this.labelMythology.TabIndex = 19;
            this.labelMythology.Text = "Mythology";
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(12, 569);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(121, 23);
            this.buttonAdvancedSearch.TabIndex = 20;
            this.buttonAdvancedSearch.Text = "Advanced Search";
            this.buttonAdvancedSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedSearch.Click += new System.EventHandler(this.buttonAdvancedSearch_Click);
            // 
            // labelNearbyConstellations
            // 
            this.labelNearbyConstellations.AutoSize = true;
            this.labelNearbyConstellations.Location = new System.Drawing.Point(208, 361);
            this.labelNearbyConstellations.Name = "labelNearbyConstellations";
            this.labelNearbyConstellations.Size = new System.Drawing.Size(109, 13);
            this.labelNearbyConstellations.TabIndex = 21;
            this.labelNearbyConstellations.Text = "Nearby Constellations";
            // 
            // richTextBoxNearbyConstellations
            // 
            this.richTextBoxNearbyConstellations.Location = new System.Drawing.Point(208, 386);
            this.richTextBoxNearbyConstellations.Name = "richTextBoxNearbyConstellations";
            this.richTextBoxNearbyConstellations.ReadOnly = true;
            this.richTextBoxNearbyConstellations.Size = new System.Drawing.Size(306, 53);
            this.richTextBoxNearbyConstellations.TabIndex = 22;
            this.richTextBoxNearbyConstellations.Text = "";
            // 
            // textBoxFindLetter
            // 
            this.textBoxFindLetter.Location = new System.Drawing.Point(12, 105);
            this.textBoxFindLetter.Name = "textBoxFindLetter";
            this.textBoxFindLetter.Size = new System.Drawing.Size(100, 20);
            this.textBoxFindLetter.TabIndex = 23;
            // 
            // buttonSearchLetter
            // 
            this.buttonSearchLetter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchLetter.Location = new System.Drawing.Point(12, 137);
            this.buttonSearchLetter.Name = "buttonSearchLetter";
            this.buttonSearchLetter.Size = new System.Drawing.Size(121, 23);
            this.buttonSearchLetter.TabIndex = 24;
            this.buttonSearchLetter.Text = "Search By Letter";
            this.buttonSearchLetter.UseVisualStyleBackColor = true;
            this.buttonSearchLetter.Click += new System.EventHandler(this.buttonSearchLetter_Click);
            // 
            // buttonShowAllConstellations
            // 
            this.buttonShowAllConstellations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShowAllConstellations.Location = new System.Drawing.Point(12, 451);
            this.buttonShowAllConstellations.Name = "buttonShowAllConstellations";
            this.buttonShowAllConstellations.Size = new System.Drawing.Size(139, 23);
            this.buttonShowAllConstellations.TabIndex = 25;
            this.buttonShowAllConstellations.Text = "Show All Constellations";
            this.buttonShowAllConstellations.UseVisualStyleBackColor = true;
            this.buttonShowAllConstellations.Click += new System.EventHandler(this.buttonShowAllConstellations_Click);
            // 
            // labelSearchByLetter
            // 
            this.labelSearchByLetter.AutoSize = true;
            this.labelSearchByLetter.Location = new System.Drawing.Point(12, 80);
            this.labelSearchByLetter.Name = "labelSearchByLetter";
            this.labelSearchByLetter.Size = new System.Drawing.Size(108, 13);
            this.labelSearchByLetter.TabIndex = 26;
            this.labelSearchByLetter.Text = "Search By First Letter";
            // 
            // labelSearchByHemisphere
            // 
            this.labelSearchByHemisphere.AutoSize = true;
            this.labelSearchByHemisphere.Location = new System.Drawing.Point(12, 172);
            this.labelSearchByHemisphere.Name = "labelSearchByHemisphere";
            this.labelSearchByHemisphere.Size = new System.Drawing.Size(115, 13);
            this.labelSearchByHemisphere.TabIndex = 27;
            this.labelSearchByHemisphere.Text = "Search By Hemisphere";
            // 
            // comboBoxSearchByHemisphere
            // 
            this.comboBoxSearchByHemisphere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchByHemisphere.FormattingEnabled = true;
            this.comboBoxSearchByHemisphere.Location = new System.Drawing.Point(12, 197);
            this.comboBoxSearchByHemisphere.Name = "comboBoxSearchByHemisphere";
            this.comboBoxSearchByHemisphere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchByHemisphere.TabIndex = 28;
            // 
            // buttonSearchByHemisphere
            // 
            this.buttonSearchByHemisphere.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchByHemisphere.Location = new System.Drawing.Point(12, 230);
            this.buttonSearchByHemisphere.Name = "buttonSearchByHemisphere";
            this.buttonSearchByHemisphere.Size = new System.Drawing.Size(136, 23);
            this.buttonSearchByHemisphere.TabIndex = 29;
            this.buttonSearchByHemisphere.Text = "Search By Hemisphere";
            this.buttonSearchByHemisphere.UseVisualStyleBackColor = true;
            this.buttonSearchByHemisphere.Click += new System.EventHandler(this.buttonSearchByHemisphere_Click);
            // 
            // labelTotalResults
            // 
            this.labelTotalResults.AutoSize = true;
            this.labelTotalResults.Location = new System.Drawing.Point(12, 544);
            this.labelTotalResults.Name = "labelTotalResults";
            this.labelTotalResults.Size = new System.Drawing.Size(69, 13);
            this.labelTotalResults.TabIndex = 30;
            this.labelTotalResults.Text = "Total Results";
            // 
            // labelSearchByFamily
            // 
            this.labelSearchByFamily.AutoSize = true;
            this.labelSearchByFamily.Location = new System.Drawing.Point(12, 265);
            this.labelSearchByFamily.Name = "labelSearchByFamily";
            this.labelSearchByFamily.Size = new System.Drawing.Size(88, 13);
            this.labelSearchByFamily.TabIndex = 31;
            this.labelSearchByFamily.Text = "Search By Family";
            // 
            // comboBoxSearchByFamily
            // 
            this.comboBoxSearchByFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchByFamily.FormattingEnabled = true;
            this.comboBoxSearchByFamily.Location = new System.Drawing.Point(12, 290);
            this.comboBoxSearchByFamily.Name = "comboBoxSearchByFamily";
            this.comboBoxSearchByFamily.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSearchByFamily.TabIndex = 32;
            // 
            // buttonSearchByFamily
            // 
            this.buttonSearchByFamily.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchByFamily.Location = new System.Drawing.Point(12, 323);
            this.buttonSearchByFamily.Name = "buttonSearchByFamily";
            this.buttonSearchByFamily.Size = new System.Drawing.Size(115, 23);
            this.buttonSearchByFamily.TabIndex = 33;
            this.buttonSearchByFamily.Text = "Search By Family";
            this.buttonSearchByFamily.UseVisualStyleBackColor = true;
            this.buttonSearchByFamily.Click += new System.EventHandler(this.buttonSearchByFamily_Click);
            // 
            // labelSearchByOrigin
            // 
            this.labelSearchByOrigin.AutoSize = true;
            this.labelSearchByOrigin.Location = new System.Drawing.Point(12, 358);
            this.labelSearchByOrigin.Name = "labelSearchByOrigin";
            this.labelSearchByOrigin.Size = new System.Drawing.Size(86, 13);
            this.labelSearchByOrigin.TabIndex = 34;
            this.labelSearchByOrigin.Text = "Search By Origin";
            // 
            // comboBoxSearchByOrigin
            // 
            this.comboBoxSearchByOrigin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSearchByOrigin.FormattingEnabled = true;
            this.comboBoxSearchByOrigin.Location = new System.Drawing.Point(12, 383);
            this.comboBoxSearchByOrigin.Name = "comboBoxSearchByOrigin";
            this.comboBoxSearchByOrigin.Size = new System.Drawing.Size(167, 21);
            this.comboBoxSearchByOrigin.TabIndex = 35;
            // 
            // buttonSearchByOrigin
            // 
            this.buttonSearchByOrigin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearchByOrigin.Location = new System.Drawing.Point(12, 416);
            this.buttonSearchByOrigin.Name = "buttonSearchByOrigin";
            this.buttonSearchByOrigin.Size = new System.Drawing.Size(115, 23);
            this.buttonSearchByOrigin.TabIndex = 36;
            this.buttonSearchByOrigin.Text = "Search By Origin";
            this.buttonSearchByOrigin.UseVisualStyleBackColor = true;
            this.buttonSearchByOrigin.Click += new System.EventHandler(this.buttonSearchByOrigin_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.buttonSearchByOrigin);
            this.Controls.Add(this.comboBoxSearchByOrigin);
            this.Controls.Add(this.labelSearchByOrigin);
            this.Controls.Add(this.buttonSearchByFamily);
            this.Controls.Add(this.comboBoxSearchByFamily);
            this.Controls.Add(this.labelSearchByFamily);
            this.Controls.Add(this.labelTotalResults);
            this.Controls.Add(this.buttonSearchByHemisphere);
            this.Controls.Add(this.comboBoxSearchByHemisphere);
            this.Controls.Add(this.labelSearchByHemisphere);
            this.Controls.Add(this.labelSearchByLetter);
            this.Controls.Add(this.buttonShowAllConstellations);
            this.Controls.Add(this.buttonSearchLetter);
            this.Controls.Add(this.textBoxFindLetter);
            this.Controls.Add(this.richTextBoxNearbyConstellations);
            this.Controls.Add(this.labelNearbyConstellations);
            this.Controls.Add(this.buttonAdvancedSearch);
            this.Controls.Add(this.labelMythology);
            this.Controls.Add(this.richTextBoxMythology);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonViewSkyImage);
            this.Controls.Add(this.buttonViewMythologyImage);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonViewStars);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelChooseRepo);
            this.Controls.Add(this.comboBoxChooseRepo);
            this.Controls.Add(this.labelChooseConstellation);
            this.Controls.Add(this.comboBoxChooseConstellation);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Constellations";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChooseConstellation;
        private System.Windows.Forms.Label labelChooseConstellation;
        private System.Windows.Forms.Label labelChooseRepo;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelAbbreviation;
        private System.Windows.Forms.Label labelGenitive;
        private System.Windows.Forms.Button buttonViewStars;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonViewMythologyImage;
        private System.Windows.Forms.Button buttonViewSkyImage;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelMeaning;
        private System.Windows.Forms.Label labelBrightestStar;
        private System.Windows.Forms.Label labelHemisphere;
        private System.Windows.Forms.Label labelBestSeen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelSeason;
        private System.Windows.Forms.RichTextBox richTextBoxMythology;
        private System.Windows.Forms.Label labelMythology;
        private System.Windows.Forms.Button buttonAdvancedSearch;
        private System.Windows.Forms.Label labelNearbyConstellations;
        private System.Windows.Forms.RichTextBox richTextBoxNearbyConstellations;
        private System.Windows.Forms.TextBox textBoxFindLetter;
        private System.Windows.Forms.Button buttonSearchLetter;
        private System.Windows.Forms.Button buttonShowAllConstellations;
        private System.Windows.Forms.Label labelSearchByLetter;
        private System.Windows.Forms.Label labelSearchByHemisphere;
        private System.Windows.Forms.ComboBox comboBoxSearchByHemisphere;
        private System.Windows.Forms.Button buttonSearchByHemisphere;
        private System.Windows.Forms.Label labelTotalResults;
        private System.Windows.Forms.ComboBox comboBoxChooseRepo;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelSearchByFamily;
        private System.Windows.Forms.ComboBox comboBoxSearchByFamily;
        private System.Windows.Forms.Button buttonSearchByFamily;
        private System.Windows.Forms.Label labelSearchByOrigin;
        private System.Windows.Forms.ComboBox comboBoxSearchByOrigin;
        private System.Windows.Forms.Button buttonSearchByOrigin;
    }
}