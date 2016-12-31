namespace Constellations.UI
{
    partial class CalenderLookUpForm
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
            this.listBoxResults = new System.Windows.Forms.ListBox();
            this.labelChooseRepo = new System.Windows.Forms.Label();
            this.comboBoxChooseRepo = new System.Windows.Forms.ComboBox();
            this.labelTotalResults = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelSelectMonth
            // 
            this.labelSelectMonth.AutoSize = true;
            this.labelSelectMonth.Location = new System.Drawing.Point(56, 198);
            this.labelSelectMonth.Name = "labelSelectMonth";
            this.labelSelectMonth.Size = new System.Drawing.Size(69, 13);
            this.labelSelectMonth.TabIndex = 1;
            this.labelSelectMonth.Text = "Select month";
            // 
            // labelSelectHemisphere
            // 
            this.labelSelectHemisphere.AutoSize = true;
            this.labelSelectHemisphere.Location = new System.Drawing.Point(56, 118);
            this.labelSelectHemisphere.Name = "labelSelectHemisphere";
            this.labelSelectHemisphere.Size = new System.Drawing.Size(96, 13);
            this.labelSelectHemisphere.TabIndex = 2;
            this.labelSelectHemisphere.Text = "Select Hemisphere";
            // 
            // comboBoxSelectHemisphere
            // 
            this.comboBoxSelectHemisphere.FormattingEnabled = true;
            this.comboBoxSelectHemisphere.Location = new System.Drawing.Point(56, 154);
            this.comboBoxSelectHemisphere.Name = "comboBoxSelectHemisphere";
            this.comboBoxSelectHemisphere.Size = new System.Drawing.Size(121, 21);
            this.comboBoxSelectHemisphere.TabIndex = 3;
            this.comboBoxSelectHemisphere.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectHemisphere_SelectedIndexChanged);
            // 
            // comboBoxSelectMonth
            // 
            this.comboBoxSelectMonth.FormattingEnabled = true;
            this.comboBoxSelectMonth.Location = new System.Drawing.Point(56, 234);
            this.comboBoxSelectMonth.Name = "comboBoxSelectMonth";
            this.comboBoxSelectMonth.Size = new System.Drawing.Size(161, 21);
            this.comboBoxSelectMonth.TabIndex = 4;
            this.comboBoxSelectMonth.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectMonth_SelectedIndexChanged);
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(56, 278);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listBoxResults
            // 
            this.listBoxResults.FormattingEnabled = true;
            this.listBoxResults.Location = new System.Drawing.Point(271, 55);
            this.listBoxResults.Name = "listBoxResults";
            this.listBoxResults.Size = new System.Drawing.Size(274, 238);
            this.listBoxResults.TabIndex = 6;
            // 
            // labelChooseRepo
            // 
            this.labelChooseRepo.AutoSize = true;
            this.labelChooseRepo.Location = new System.Drawing.Point(56, 38);
            this.labelChooseRepo.Name = "labelChooseRepo";
            this.labelChooseRepo.Size = new System.Drawing.Size(96, 13);
            this.labelChooseRepo.TabIndex = 7;
            this.labelChooseRepo.Text = "Choose Repository";
            // 
            // comboBoxChooseRepo
            // 
            this.comboBoxChooseRepo.FormattingEnabled = true;
            this.comboBoxChooseRepo.Location = new System.Drawing.Point(56, 74);
            this.comboBoxChooseRepo.Name = "comboBoxChooseRepo";
            this.comboBoxChooseRepo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxChooseRepo.TabIndex = 8;
            // 
            // labelTotalResults
            // 
            this.labelTotalResults.AutoSize = true;
            this.labelTotalResults.Location = new System.Drawing.Point(271, 23);
            this.labelTotalResults.Name = "labelTotalResults";
            this.labelTotalResults.Size = new System.Drawing.Size(0, 13);
            this.labelTotalResults.TabIndex = 9;
            // 
            // CalenderLookUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 371);
            this.Controls.Add(this.labelTotalResults);
            this.Controls.Add(this.comboBoxChooseRepo);
            this.Controls.Add(this.labelChooseRepo);
            this.Controls.Add(this.listBoxResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxSelectMonth);
            this.Controls.Add(this.comboBoxSelectHemisphere);
            this.Controls.Add(this.labelSelectHemisphere);
            this.Controls.Add(this.labelSelectMonth);
            this.Name = "CalenderLookUpForm";
            this.Text = "Advanced Search";
            this.Load += new System.EventHandler(this.CalenderLookUpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSelectMonth;
        private System.Windows.Forms.Label labelSelectHemisphere;
        private System.Windows.Forms.ComboBox comboBoxSelectHemisphere;
        private System.Windows.Forms.ComboBox comboBoxSelectMonth;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.ListBox listBoxResults;
        private System.Windows.Forms.Label labelChooseRepo;
        private System.Windows.Forms.ComboBox comboBoxChooseRepo;
        private System.Windows.Forms.Label labelTotalResults;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}