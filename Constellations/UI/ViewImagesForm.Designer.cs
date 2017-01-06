namespace Constellations.UI
{
    partial class ViewImagesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewImagesForm));
            this.buttonViewSky = new System.Windows.Forms.Button();
            this.buttonViewStarMap = new System.Windows.Forms.Button();
            this.buttonViewMyth = new System.Windows.Forms.Button();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonViewSky
            // 
            this.buttonViewSky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewSky.Location = new System.Drawing.Point(50, 12);
            this.buttonViewSky.Name = "buttonViewSky";
            this.buttonViewSky.Size = new System.Drawing.Size(144, 23);
            this.buttonViewSky.TabIndex = 0;
            this.buttonViewSky.Text = "View Natural Sky Image";
            this.buttonViewSky.UseVisualStyleBackColor = true;
            this.buttonViewSky.Click += new System.EventHandler(this.buttonViewSky_Click);
            // 
            // buttonViewStarMap
            // 
            this.buttonViewStarMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewStarMap.Location = new System.Drawing.Point(295, 12);
            this.buttonViewStarMap.Name = "buttonViewStarMap";
            this.buttonViewStarMap.Size = new System.Drawing.Size(124, 23);
            this.buttonViewStarMap.TabIndex = 1;
            this.buttonViewStarMap.Text = "View Star Map Image";
            this.buttonViewStarMap.UseVisualStyleBackColor = true;
            this.buttonViewStarMap.Click += new System.EventHandler(this.buttonViewStarMap_Click);
            // 
            // buttonViewMyth
            // 
            this.buttonViewMyth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonViewMyth.Location = new System.Drawing.Point(511, 12);
            this.buttonViewMyth.Name = "buttonViewMyth";
            this.buttonViewMyth.Size = new System.Drawing.Size(129, 23);
            this.buttonViewMyth.TabIndex = 2;
            this.buttonViewMyth.Text = "View Mythology Image";
            this.buttonViewMyth.UseVisualStyleBackColor = true;
            this.buttonViewMyth.Click += new System.EventHandler(this.buttonViewMyth_Click);
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(12, 41);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(192, 238);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxImage.TabIndex = 3;
            this.pictureBoxImage.TabStop = false;
            // 
            // ViewImagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(674, 691);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.buttonViewMyth);
            this.Controls.Add(this.buttonViewStarMap);
            this.Controls.Add(this.buttonViewSky);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ViewImagesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Images";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonViewSky;
        private System.Windows.Forms.Button buttonViewStarMap;
        private System.Windows.Forms.Button buttonViewMyth;
        private System.Windows.Forms.PictureBox pictureBoxImage;
    }
}