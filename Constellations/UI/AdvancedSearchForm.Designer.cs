namespace Constellations.UI
{
    partial class AdvancedSearchForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdvancedSearchForm));
            this.labelSelectMonth = new System.Windows.Forms.Label();
            this.labelSelectHemisphere = new System.Windows.Forms.Label();
            this.comboBoxSelectHemisphere = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectMonth = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelChooseRepo = new System.Windows.Forms.Label();
            this.comboBoxChooseRepo = new System.Windows.Forms.ComboBox();
            this.labelTotalResults = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelAbbreviation = new System.Windows.Forms.Label();
            this.labelGenitive = new System.Windows.Forms.Label();
            this.labelFamily = new System.Windows.Forms.Label();
            this.labelOrigin = new System.Windows.Forms.Label();
            this.labelBrightestStar = new System.Windows.Forms.Label();
            this.labelMeaning = new System.Windows.Forms.Label();
            this.richTextBoxNearbyConstellations = new System.Windows.Forms.RichTextBox();
            this.labelNearbyConstellations = new System.Windows.Forms.Label();
            this.richTextBoxMythology = new System.Windows.Forms.RichTextBox();
            this.labelMythology = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelSelectMonth
            // 
            this.labelSelectMonth.AutoSize = true;
            this.labelSelectMonth.Location = new System.Drawing.Point(6, 204);
            this.labelSelectMonth.Name = "labelSelectMonth";
            this.labelSelectMonth.Size = new System.Drawing.Size(69, 13);
            this.labelSelectMonth.TabIndex = 1;
            this.labelSelectMonth.Text = "Select month";
            // 
            // labelSelectHemisphere
            // 
            this.labelSelectHemisphere.AutoSize = true;
            this.labelSelectHemisphere.Location = new System.Drawing.Point(6, 120);
            this.labelSelectHemisphere.Name = "labelSelectHemisphere";
            this.labelSelectHemisphere.Size = new System.Drawing.Size(96, 13);
            this.labelSelectHemisphere.TabIndex = 2;
            this.labelSelectHemisphere.Text = "Select Hemisphere";
            // 
            // comboBoxSelectHemisphere
            // 
            this.comboBoxSelectHemisphere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectHemisphere.FormattingEnabled = true;
            this.comboBoxSelectHemisphere.Location = new System.Drawing.Point(6, 158);
            this.comboBoxSelectHemisphere.Name = "comboBoxSelectHemisphere";
            this.comboBoxSelectHemisphere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectHemisphere.TabIndex = 3;
            this.comboBoxSelectHemisphere.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectHemisphere_SelectedIndexChanged);
            // 
            // comboBoxSelectMonth
            // 
            this.comboBoxSelectMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSelectMonth.FormattingEnabled = true;
            this.comboBoxSelectMonth.Location = new System.Drawing.Point(6, 242);
            this.comboBoxSelectMonth.Name = "comboBoxSelectMonth";
            this.comboBoxSelectMonth.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSelectMonth.TabIndex = 4;
            this.comboBoxSelectMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectMonth_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(6, 288);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelChooseRepo
            // 
            this.labelChooseRepo.AutoSize = true;
            this.labelChooseRepo.Location = new System.Drawing.Point(6, 36);
            this.labelChooseRepo.Name = "labelChooseRepo";
            this.labelChooseRepo.Size = new System.Drawing.Size(96, 13);
            this.labelChooseRepo.TabIndex = 7;
            this.labelChooseRepo.Text = "Choose Repository";
            // 
            // comboBoxChooseRepo
            // 
            this.comboBoxChooseRepo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChooseRepo.FormattingEnabled = true;
            this.comboBoxChooseRepo.Location = new System.Drawing.Point(6, 74);
            this.comboBoxChooseRepo.Name = "comboBoxChooseRepo";
            this.comboBoxChooseRepo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseRepo.TabIndex = 8;
            // 
            // labelTotalResults
            // 
            this.labelTotalResults.AutoSize = true;
            this.labelTotalResults.Location = new System.Drawing.Point(202, 37);
            this.labelTotalResults.Name = "labelTotalResults";
            this.labelTotalResults.Size = new System.Drawing.Size(69, 13);
            this.labelTotalResults.TabIndex = 9;
            this.labelTotalResults.Text = "Total Results";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelChooseRepo);
            this.groupBox1.Controls.Add(this.labelSelectMonth);
            this.groupBox1.Controls.Add(this.comboBoxChooseRepo);
            this.groupBox1.Controls.Add(this.comboBoxSelectMonth);
            this.groupBox1.Controls.Add(this.labelSelectHemisphere);
            this.groupBox1.Controls.Add(this.comboBoxSelectHemisphere);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 344);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search By Hemisphere/Month";
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(205, 62);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(217, 238);
            this.listBoxResults.TabIndex = 12;
            this.listBoxResults.SelectedIndexChanged += new System.EventHandler(this.listBoxResults_SelectedIndexChanged);
            // 
            // labelAbbreviation
            // 
            this.labelAbbreviation.AutoSize = true;
            this.labelAbbreviation.Location = new System.Drawing.Point(472, 39);
            this.labelAbbreviation.Name = "labelAbbreviation";
            this.labelAbbreviation.Size = new System.Drawing.Size(66, 13);
            this.labelAbbreviation.TabIndex = 13;
            this.labelAbbreviation.Text = "Abbreviation";
            // 
            // labelGenitive
            // 
            this.labelGenitive.AutoSize = true;
            this.labelGenitive.Location = new System.Drawing.Point(472, 65);
            this.labelGenitive.Name = "labelGenitive";
            this.labelGenitive.Size = new System.Drawing.Size(46, 13);
            this.labelGenitive.TabIndex = 14;
            this.labelGenitive.Text = "Genitive";
            // 
            // labelFamily
            // 
            this.labelFamily.AutoSize = true;
            this.labelFamily.Location = new System.Drawing.Point(472, 91);
            this.labelFamily.Name = "labelFamily";
            this.labelFamily.Size = new System.Drawing.Size(36, 13);
            this.labelFamily.TabIndex = 15;
            this.labelFamily.Text = "Family";
            // 
            // labelOrigin
            // 
            this.labelOrigin.AutoSize = true;
            this.labelOrigin.Location = new System.Drawing.Point(472, 117);
            this.labelOrigin.Name = "labelOrigin";
            this.labelOrigin.Size = new System.Drawing.Size(34, 13);
            this.labelOrigin.TabIndex = 16;
            this.labelOrigin.Text = "Origin";
            // 
            // labelBrightestStar
            // 
            this.labelBrightestStar.AutoSize = true;
            this.labelBrightestStar.Location = new System.Drawing.Point(472, 169);
            this.labelBrightestStar.Name = "labelBrightestStar";
            this.labelBrightestStar.Size = new System.Drawing.Size(70, 13);
            this.labelBrightestStar.TabIndex = 17;
            this.labelBrightestStar.Text = "Brightest Star";
            // 
            // labelMeaning
            // 
            this.labelMeaning.AutoSize = true;
            this.labelMeaning.Location = new System.Drawing.Point(472, 143);
            this.labelMeaning.Name = "labelMeaning";
            this.labelMeaning.Size = new System.Drawing.Size(48, 13);
            this.labelMeaning.TabIndex = 18;
            this.labelMeaning.Text = "Meaning";
            // 
            // richTextBoxNearbyConstellations
            // 
            this.richTextBoxNearbyConstellations.Location = new System.Drawing.Point(472, 228);
            this.richTextBoxNearbyConstellations.Name = "richTextBoxNearbyConstellations";
            this.richTextBoxNearbyConstellations.ReadOnly = true;
            this.richTextBoxNearbyConstellations.Size = new System.Drawing.Size(225, 49);
            this.richTextBoxNearbyConstellations.TabIndex = 19;
            this.richTextBoxNearbyConstellations.Text = "";
            // 
            // labelNearbyConstellations
            // 
            this.labelNearbyConstellations.AutoSize = true;
            this.labelNearbyConstellations.Location = new System.Drawing.Point(472, 209);
            this.labelNearbyConstellations.Name = "labelNearbyConstellations";
            this.labelNearbyConstellations.Size = new System.Drawing.Size(109, 13);
            this.labelNearbyConstellations.TabIndex = 20;
            this.labelNearbyConstellations.Text = "Nearby Constellations";
            // 
            // richTextBoxMythology
            // 
            this.richTextBoxMythology.Location = new System.Drawing.Point(472, 313);
            this.richTextBoxMythology.Name = "richTextBoxMythology";
            this.richTextBoxMythology.ReadOnly = true;
            this.richTextBoxMythology.Size = new System.Drawing.Size(225, 58);
            this.richTextBoxMythology.TabIndex = 21;
            this.richTextBoxMythology.Text = "";
            // 
            // labelMythology
            // 
            this.labelMythology.AutoSize = true;
            this.labelMythology.Location = new System.Drawing.Point(472, 294);
            this.labelMythology.Name = "labelMythology";
            this.labelMythology.Size = new System.Drawing.Size(55, 13);
            this.labelMythology.TabIndex = 22;
            this.labelMythology.Text = "Mythology";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(472, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 23;
            this.labelName.Text = "Name";
            // 
            // AdvancedSearchForm
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 392);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelMythology);
            this.Controls.Add(this.richTextBoxMythology);
            this.Controls.Add(this.labelNearbyConstellations);
            this.Controls.Add(this.richTextBoxNearbyConstellations);
            this.Controls.Add(this.labelMeaning);
            this.Controls.Add(this.labelBrightestStar);
            this.Controls.Add(this.labelOrigin);
            this.Controls.Add(this.labelFamily);
            this.Controls.Add(this.labelGenitive);
            this.Controls.Add(this.labelAbbreviation);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotalResults);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AdvancedSearchForm";
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.CalenderLookUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectMonth;
        private System.Windows.Forms.Label labelSelectHemisphere;
        private System.Windows.Forms.ComboBox comboBoxSelectHemisphere;
        private System.Windows.Forms.ComboBox comboBoxSelectMonth;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelChooseRepo;
        private System.Windows.Forms.ComboBox comboBoxChooseRepo;
        private System.Windows.Forms.Label labelTotalResults;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label labelAbbreviation;
        private System.Windows.Forms.Label labelGenitive;
        private System.Windows.Forms.Label labelFamily;
        private System.Windows.Forms.Label labelOrigin;
        private System.Windows.Forms.Label labelBrightestStar;
        private System.Windows.Forms.Label labelMeaning;
        private System.Windows.Forms.RichTextBox richTextBoxNearbyConstellations;
        private System.Windows.Forms.Label labelNearbyConstellations;
        private System.Windows.Forms.RichTextBox richTextBoxMythology;
        private System.Windows.Forms.Label labelMythology;
        private System.Windows.Forms.Label labelName;
    }
}