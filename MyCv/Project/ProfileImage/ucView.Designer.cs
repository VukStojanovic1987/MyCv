namespace MyCv.Project.ProfileImage
{
    partial class ucView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panContent = new System.Windows.Forms.Panel();
            this.panProfileImage = new System.Windows.Forms.Panel();
            this.lblProfileImage = new System.Windows.Forms.Label();
            this.picProfileImage = new System.Windows.Forms.PictureBox();
            this.panProfileImageHeader = new System.Windows.Forms.Panel();
            this.lblVisible = new System.Windows.Forms.Label();
            this.panHeader.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panProfileImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).BeginInit();
            this.panProfileImageHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.DimGray;
            this.panHeader.Controls.Add(this.lblHeading);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(455, 80);
            this.panHeader.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblHeading.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeading.Location = new System.Drawing.Point(22, 22);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(30, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "...";
            // 
            // panContent
            // 
            this.panContent.AutoScroll = true;
            this.panContent.AutoScrollMargin = new System.Drawing.Size(0, 22);
            this.panContent.BackColor = System.Drawing.Color.Gainsboro;
            this.panContent.Controls.Add(this.panProfileImage);
            this.panContent.Controls.Add(this.panProfileImageHeader);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 80);
            this.panContent.Margin = new System.Windows.Forms.Padding(0);
            this.panContent.Name = "panContent";
            this.panContent.Padding = new System.Windows.Forms.Padding(22);
            this.panContent.Size = new System.Drawing.Size(455, 573);
            this.panContent.TabIndex = 1;
            // 
            // panProfileImage
            // 
            this.panProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panProfileImage.Controls.Add(this.lblProfileImage);
            this.panProfileImage.Controls.Add(this.picProfileImage);
            this.panProfileImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProfileImage.Location = new System.Drawing.Point(22, 66);
            this.panProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.panProfileImage.Name = "panProfileImage";
            this.panProfileImage.Size = new System.Drawing.Size(411, 248);
            this.panProfileImage.TabIndex = 1;
            // 
            // lblProfileImage
            // 
            this.lblProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblProfileImage.Location = new System.Drawing.Point(22, 182);
            this.lblProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.lblProfileImage.Name = "lblProfileImage";
            this.lblProfileImage.Size = new System.Drawing.Size(160, 44);
            this.lblProfileImage.TabIndex = 0;
            this.lblProfileImage.Text = "...";
            this.lblProfileImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblProfileImage.Click += new System.EventHandler(this.lblProfileImage_Click);
            this.lblProfileImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblProfileImage_MouseDown);
            this.lblProfileImage.MouseEnter += new System.EventHandler(this.lblProfileImage_MouseEnter);
            this.lblProfileImage.MouseLeave += new System.EventHandler(this.lblProfileImage_MouseLeave);
            // 
            // picProfileImage
            // 
            this.picProfileImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.picProfileImage.Location = new System.Drawing.Point(22, 22);
            this.picProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.picProfileImage.Name = "picProfileImage";
            this.picProfileImage.Size = new System.Drawing.Size(160, 160);
            this.picProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picProfileImage.TabIndex = 0;
            this.picProfileImage.TabStop = false;
            // 
            // panProfileImageHeader
            // 
            this.panProfileImageHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panProfileImageHeader.Controls.Add(this.lblVisible);
            this.panProfileImageHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProfileImageHeader.Location = new System.Drawing.Point(22, 22);
            this.panProfileImageHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panProfileImageHeader.Name = "panProfileImageHeader";
            this.panProfileImageHeader.Size = new System.Drawing.Size(411, 44);
            this.panProfileImageHeader.TabIndex = 0;
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblVisible.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVisible.ForeColor = System.Drawing.Color.DimGray;
            this.lblVisible.Location = new System.Drawing.Point(345, 0);
            this.lblVisible.Margin = new System.Windows.Forms.Padding(0);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Padding = new System.Windows.Forms.Padding(22, 12, 22, 11);
            this.lblVisible.Size = new System.Drawing.Size(66, 44);
            this.lblVisible.TabIndex = 0;
            this.lblVisible.Text = "...";
            this.lblVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisible.Click += new System.EventHandler(this.lblVisible_Click);
            this.lblVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseDown);
            this.lblVisible.MouseEnter += new System.EventHandler(this.lblVisible_MouseEnter);
            this.lblVisible.MouseLeave += new System.EventHandler(this.lblVisible_MouseLeave);
            // 
            // ucView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panHeader);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucView";
            this.Size = new System.Drawing.Size(455, 653);
            this.Load += new System.EventHandler(this.ucView_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.panContent.ResumeLayout(false);
            this.panProfileImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picProfileImage)).EndInit();
            this.panProfileImageHeader.ResumeLayout(false);
            this.panProfileImageHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Panel panProfileImage;
        private System.Windows.Forms.PictureBox picProfileImage;
        private System.Windows.Forms.Panel panProfileImageHeader;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.Label lblProfileImage;
    }
}
