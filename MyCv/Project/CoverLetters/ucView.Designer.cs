namespace MyCv.Project.CoverLetters
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panContent = new System.Windows.Forms.Panel();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.DimGray;
            this.lblAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblAdd.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAdd.Location = new System.Drawing.Point(375, 0);
            this.lblAdd.Margin = new System.Windows.Forms.Padding(0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(80, 80);
            this.lblAdd.TabIndex = 1;
            this.lblAdd.Text = "...";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAdd.Click += new System.EventHandler(this.lblAdd_Click);
            this.lblAdd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAdd_MouseDown);
            this.lblAdd.MouseEnter += new System.EventHandler(this.lblAdd_MouseEnter);
            this.lblAdd.MouseLeave += new System.EventHandler(this.lblAdd_MouseLeave);
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.DimGray;
            this.panHeader.Controls.Add(this.lblAdd);
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
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 80);
            this.panContent.Margin = new System.Windows.Forms.Padding(0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(455, 573);
            this.panContent.TabIndex = 6;
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
            this.Load += new System.EventHandler(this.ucEducation_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panContent;
    }
}
