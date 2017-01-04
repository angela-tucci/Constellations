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
            this.labelSelectMonth = new System.Windows.Forms.Label();
            this.labelSelectHemisphere = new System.Windows.Forms.Label();
            this.comboBoxSelectHemisphere = new System.Windows.Forms.ComboBox();
            this.comboBoxSelectMonth = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelChooseRepo = new System.Windows.Forms.Label();
            this.comboBoxChooseRepo = new System.Windows.Forms.ComboBox();
            this.labelTotalResults = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.buttonSearchNearby = new System.Windows.Forms.Button();
            this.comboBoxSelectConstellation = new System.Windows.Forms.ComboBox();
            this.labelSelectConstellation = new System.Windows.Forms.Label();
            this.comboBoxChooseRepoNearby = new System.Windows.Forms.ComboBox();
            this.labelChooseRepoNearby = new System.Windows.Forms.Label();
            this.labelSearchByNearbyConstellations = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.groupBoxMisc = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxMisc.SuspendLayout();
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
            this.comboBoxSelectHemisphere.FormattingEnabled = true;
            this.comboBoxSelectHemisphere.Location = new System.Drawing.Point(6, 158);
            this.comboBoxSelectHemisphere.Name = "comboBoxSelectHemisphere";
            this.comboBoxSelectHemisphere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectHemisphere.TabIndex = 3;
            this.comboBoxSelectHemisphere.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectHemisphere_SelectedIndexChanged);
            // 
            // comboBoxSelectMonth
            // 
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
            this.comboBoxChooseRepo.FormattingEnabled = true;
            this.comboBoxChooseRepo.Location = new System.Drawing.Point(6, 74);
            this.comboBoxChooseRepo.Name = "comboBoxChooseRepo";
            this.comboBoxChooseRepo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseRepo.TabIndex = 8;
            // 
            // labelTotalResults
            // 
            this.labelTotalResults.AutoSize = true;
            this.labelTotalResults.Location = new System.Drawing.Point(428, 26);
            this.labelTotalResults.Name = "labelTotalResults";
            this.labelTotalResults.Size = new System.Drawing.Size(69, 13);
            this.labelTotalResults.TabIndex = 9;
            this.labelTotalResults.Text = "Total Results";
            // 
            // buttonSearchNearby
            // 
            this.buttonSearchNearby.Location = new System.Drawing.Point(28, 280);
            this.buttonSearchNearby.Name = "buttonSearchNearby";
            this.buttonSearchNearby.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchNearby.TabIndex = 5;
            this.buttonSearchNearby.Text = "Search";
            this.buttonSearchNearby.UseVisualStyleBackColor = true;
            this.buttonSearchNearby.Click += new System.EventHandler(this.buttonSearchNearby_Click);
            // 
            // comboBoxSelectConstellation
            // 
            this.comboBoxSelectConstellation.FormattingEnabled = true;
            this.comboBoxSelectConstellation.Location = new System.Drawing.Point(28, 199);
            this.comboBoxSelectConstellation.Name = "comboBoxSelectConstellation";
            this.comboBoxSelectConstellation.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectConstellation.TabIndex = 4;
            this.comboBoxSelectConstellation.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectConstellation_SelectedIndexChanged);
            // 
            // labelSelectConstellation
            // 
            this.labelSelectConstellation.AutoSize = true;
            this.labelSelectConstellation.Location = new System.Drawing.Point(25, 161);
            this.labelSelectConstellation.Name = "labelSelectConstellation";
            this.labelSelectConstellation.Size = new System.Drawing.Size(100, 13);
            this.labelSelectConstellation.TabIndex = 3;
            this.labelSelectConstellation.Text = "Select Constellation";
            // 
            // comboBoxChooseRepoNearby
            // 
            this.comboBoxChooseRepoNearby.FormattingEnabled = true;
            this.comboBoxChooseRepoNearby.Location = new System.Drawing.Point(25, 115);
            this.comboBoxChooseRepoNearby.Name = "comboBoxChooseRepoNearby";
            this.comboBoxChooseRepoNearby.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseRepoNearby.TabIndex = 2;
            // 
            // labelChooseRepoNearby
            // 
            this.labelChooseRepoNearby.AutoSize = true;
            this.labelChooseRepoNearby.Location = new System.Drawing.Point(22, 77);
            this.labelChooseRepoNearby.Name = "labelChooseRepoNearby";
            this.labelChooseRepoNearby.Size = new System.Drawing.Size(96, 13);
            this.labelChooseRepoNearby.TabIndex = 1;
            this.labelChooseRepoNearby.Text = "Choose Repository";
            // 
            // labelSearchByNearbyConstellations
            // 
            this.labelSearchByNearbyConstellations.AutoSize = true;
            this.labelSearchByNearbyConstellations.Location = new System.Drawing.Point(6, 38);
            this.labelSearchByNearbyConstellations.Name = "labelSearchByNearbyConstellations";
            this.labelSearchByNearbyConstellations.Size = new System.Drawing.Size(164, 13);
            this.labelSearchByNearbyConstellations.TabIndex = 0;
            this.labelSearchByNearbyConstellations.Text = "Search For Nearby Constellations";
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
            this.listBoxResults.Location = new System.Drawing.Point(431, 51);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(217, 238);
            this.listBoxResults.TabIndex = 12;
            // 
            // groupBoxMisc
            // 
            this.groupBoxMisc.Controls.Add(this.labelSearchByNearbyConstellations);
            this.groupBoxMisc.Controls.Add(this.comboBoxChooseRepoNearby);
            this.groupBoxMisc.Controls.Add(this.buttonSearchNearby);
            this.groupBoxMisc.Controls.Add(this.labelSelectConstellation);
            this.groupBoxMisc.Controls.Add(this.labelChooseRepoNearby);
            this.groupBoxMisc.Controls.Add(this.comboBoxSelectConstellation);
            this.groupBoxMisc.Location = new System.Drawing.Point(206, 26);
            this.groupBoxMisc.Name = "groupBoxMisc";
            this.groupBoxMisc.Size = new System.Drawing.Size(200, 308);
            this.groupBoxMisc.TabIndex = 13;
            this.groupBoxMisc.TabStop = false;
            this.groupBoxMisc.Text = "Other Stuff for later";
            // 
            // AdvancedSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 371);
            this.Controls.Add(this.groupBoxMisc);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelTotalResults);
            this.Name = "AdvancedSearchForm";
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.CalenderLookUpForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxMisc.ResumeLayout(false);
            this.groupBoxMisc.PerformLayout();
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
        private System.Windows.Forms.Button buttonSearchNearby;
        private System.Windows.Forms.ComboBox comboBoxSelectConstellation;
        private System.Windows.Forms.Label labelSelectConstellation;
        private System.Windows.Forms.ComboBox comboBoxChooseRepoNearby;
        private System.Windows.Forms.Label labelChooseRepoNearby;
        private System.Windows.Forms.Label labelSearchByNearbyConstellations;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.GroupBox groupBoxMisc;
    }
}