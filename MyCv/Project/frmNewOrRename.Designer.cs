namespace MyCv.Project
{
    partial class frmNewOrRename
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.panContent = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblOk = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.panFooter = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panContent.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.panFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.Gainsboro;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(47, 29);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(555, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // panContent
            // 
            this.panContent.BackColor = System.Drawing.Color.Gainsboro;
            this.panContent.Controls.Add(this.txtName);
            this.panContent.Controls.Add(this.lblName);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(0, 80);
            this.panContent.Margin = new System.Windows.Forms.Padding(0);
            this.panContent.Name = "panContent";
            this.panContent.Padding = new System.Windows.Forms.Padding(22, 29, 22, 29);
            this.panContent.Size = new System.Drawing.Size(624, 80);
            this.panContent.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Gainsboro;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(22, 29);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.lblName.Size = new System.Drawing.Size(25, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "...";
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.Gray;
            this.panHeader.Controls.Add(this.lblOk);
            this.panHeader.Controls.Add(this.lblCancel);
            this.panHeader.Controls.Add(this.lblHeading);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(624, 80);
            this.panHeader.TabIndex = 0;
            // 
            // lblOk
            // 
            this.lblOk.BackColor = System.Drawing.Color.Gray;
            this.lblOk.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblOk.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOk.Location = new System.Drawing.Point(464, 0);
            this.lblOk.Margin = new System.Windows.Forms.Padding(0);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(80, 80);
            this.lblOk.TabIndex = 1;
            this.lblOk.Text = "...";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOk.Click += new System.EventHandler(this.lblOk_Click);
            this.lblOk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOk_MouseDown);
            this.lblOk.MouseEnter += new System.EventHandler(this.lblOk_MouseEnter);
            this.lblOk.MouseLeave += new System.EventHandler(this.lblOk_MouseLeave);
            // 
            // lblCancel
            // 
            this.lblCancel.BackColor = System.Drawing.Color.Gray;
            this.lblCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblCancel.Location = new System.Drawing.Point(544, 0);
            this.lblCancel.Margin = new System.Windows.Forms.Padding(0);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(80, 80);
            this.lblCancel.TabIndex = 2;
            this.lblCancel.Text = "...";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCancel_MouseDown);
            this.lblCancel.MouseEnter += new System.EventHandler(this.lblCancel_MouseEnter);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeading.Location = new System.Drawing.Point(22, 30);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(22, 21);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "...";
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.Color.Gray;
            this.panFooter.Controls.Add(this.lblMessage);
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(0, 160);
            this.panFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panFooter.Name = "panFooter";
            this.panFooter.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.panFooter.Size = new System.Drawing.Size(624, 25);
            this.panFooter.TabIndex = 2;
            // 
            // lblMessage
            // 
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessage.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMessage.Location = new System.Drawing.Point(22, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblMessage.Size = new System.Drawing.Size(580, 25);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmNewOrRename
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 185);
            this.Controls.Add(this.panContent);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panFooter);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmNewOrRename";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyCv";
            this.Load += new System.EventHandler(this.frmNewOrRename_Load);
            this.Shown += new System.EventHandler(this.frmNewOrRename_Shown);
            this.panContent.ResumeLayout(false);
            this.panContent.PerformLayout();
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.panFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Label lblMessage;
    }
}