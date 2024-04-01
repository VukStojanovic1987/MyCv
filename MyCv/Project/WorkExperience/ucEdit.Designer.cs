namespace MyCv.Project.WorkExperience
{
    partial class ucEdit
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
            this.lblVisible = new System.Windows.Forms.Label();
            this.lblRemove = new System.Windows.Forms.Label();
            this.panShell = new System.Windows.Forms.Panel();
            this.panMessage = new System.Windows.Forms.Panel();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panContent = new System.Windows.Forms.Panel();
            this.panDescription = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panAttended = new System.Windows.Forms.Panel();
            this.txtAttended = new System.Windows.Forms.TextBox();
            this.lblAttended = new System.Windows.Forms.Label();
            this.panPosition = new System.Windows.Forms.Panel();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lblPosition = new System.Windows.Forms.Label();
            this.panName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panHeader.SuspendLayout();
            this.panShell.SuspendLayout();
            this.panMessage.SuspendLayout();
            this.panContent.SuspendLayout();
            this.panDescription.SuspendLayout();
            this.panAttended.SuspendLayout();
            this.panPosition.SuspendLayout();
            this.panName.SuspendLayout();
            this.SuspendLayout();
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panHeader.Controls.Add(this.lblHeading);
            this.panHeader.Controls.Add(this.lblVisible);
            this.panHeader.Controls.Add(this.lblRemove);
            this.panHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panHeader.Location = new System.Drawing.Point(0, 0);
            this.panHeader.Margin = new System.Windows.Forms.Padding(0);
            this.panHeader.Name = "panHeader";
            this.panHeader.Size = new System.Drawing.Size(411, 44);
            this.panHeader.TabIndex = 0;
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeading.ForeColor = System.Drawing.Color.Black;
            this.lblHeading.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHeading.Location = new System.Drawing.Point(0, 0);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Padding = new System.Windows.Forms.Padding(22, 12, 22, 11);
            this.lblHeading.Size = new System.Drawing.Size(66, 44);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "...";
            // 
            // lblVisible
            // 
            this.lblVisible.AutoSize = true;
            this.lblVisible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblVisible.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVisible.ForeColor = System.Drawing.Color.DimGray;
            this.lblVisible.Location = new System.Drawing.Point(279, 0);
            this.lblVisible.Margin = new System.Windows.Forms.Padding(0);
            this.lblVisible.Name = "lblVisible";
            this.lblVisible.Padding = new System.Windows.Forms.Padding(22, 12, 22, 11);
            this.lblVisible.Size = new System.Drawing.Size(66, 44);
            this.lblVisible.TabIndex = 1;
            this.lblVisible.Text = "...";
            this.lblVisible.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVisible.Click += new System.EventHandler(this.lblVisible_Click);
            this.lblVisible.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblVisible_MouseDown);
            this.lblVisible.MouseEnter += new System.EventHandler(this.lblVisible_MouseEnter);
            this.lblVisible.MouseLeave += new System.EventHandler(this.lblVisible_MouseLeave);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.lblRemove.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblRemove.ForeColor = System.Drawing.Color.DimGray;
            this.lblRemove.Location = new System.Drawing.Point(345, 0);
            this.lblRemove.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Padding = new System.Windows.Forms.Padding(22, 12, 22, 11);
            this.lblRemove.Size = new System.Drawing.Size(66, 44);
            this.lblRemove.TabIndex = 2;
            this.lblRemove.Text = "...";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            this.lblRemove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRemove_MouseDown);
            this.lblRemove.MouseEnter += new System.EventHandler(this.lblRemove_MouseEnter);
            this.lblRemove.MouseLeave += new System.EventHandler(this.lblRemove_MouseLeave);
            // 
            // panShell
            // 
            this.panShell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panShell.Controls.Add(this.panMessage);
            this.panShell.Controls.Add(this.panContent);
            this.panShell.Controls.Add(this.panHeader);
            this.panShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panShell.Location = new System.Drawing.Point(22, 22);
            this.panShell.Margin = new System.Windows.Forms.Padding(0);
            this.panShell.Name = "panShell";
            this.panShell.Size = new System.Drawing.Size(411, 308);
            this.panShell.TabIndex = 0;
            // 
            // panMessage
            // 
            this.panMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panMessage.Controls.Add(this.lblNo);
            this.panMessage.Controls.Add(this.lblYes);
            this.panMessage.Controls.Add(this.lblMessage);
            this.panMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMessage.Location = new System.Drawing.Point(0, 264);
            this.panMessage.Margin = new System.Windows.Forms.Padding(0);
            this.panMessage.Name = "panMessage";
            this.panMessage.Size = new System.Drawing.Size(411, 44);
            this.panMessage.TabIndex = 1;
            this.panMessage.Visible = false;
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNo.ForeColor = System.Drawing.Color.MistyRose;
            this.lblNo.Location = new System.Drawing.Point(91, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(44, 44);
            this.lblNo.TabIndex = 0;
            this.lblNo.Text = "...";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            this.lblNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNo_MouseDown);
            this.lblNo.MouseEnter += new System.EventHandler(this.lblNo_MouseEnter);
            this.lblNo.MouseLeave += new System.EventHandler(this.lblNo_MouseLeave);
            // 
            // lblYes
            // 
            this.lblYes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.lblYes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblYes.ForeColor = System.Drawing.Color.MistyRose;
            this.lblYes.Location = new System.Drawing.Point(47, 0);
            this.lblYes.Margin = new System.Windows.Forms.Padding(0);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(44, 44);
            this.lblYes.TabIndex = 1;
            this.lblYes.Text = "...";
            this.lblYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            this.lblYes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblYes_MouseDown);
            this.lblYes.MouseEnter += new System.EventHandler(this.lblYes_MouseEnter);
            this.lblYes.MouseLeave += new System.EventHandler(this.lblYes_MouseLeave);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblMessage.ForeColor = System.Drawing.Color.MistyRose;
            this.lblMessage.Location = new System.Drawing.Point(0, 0);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(22, 12, 3, 11);
            this.lblMessage.Size = new System.Drawing.Size(47, 44);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "...";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panContent
            // 
            this.panContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panContent.Controls.Add(this.panDescription);
            this.panContent.Controls.Add(this.panAttended);
            this.panContent.Controls.Add(this.panPosition);
            this.panContent.Controls.Add(this.panName);
            this.panContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panContent.Location = new System.Drawing.Point(0, 44);
            this.panContent.Margin = new System.Windows.Forms.Padding(0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(411, 220);
            this.panContent.TabIndex = 1;
            // 
            // panDescription
            // 
            this.panDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panDescription.Controls.Add(this.txtDescription);
            this.panDescription.Controls.Add(this.lblDescription);
            this.panDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.panDescription.Location = new System.Drawing.Point(0, 132);
            this.panDescription.Margin = new System.Windows.Forms.Padding(0);
            this.panDescription.Name = "panDescription";
            this.panDescription.Padding = new System.Windows.Forms.Padding(22, 22, 22, 0);
            this.panDescription.Size = new System.Drawing.Size(411, 66);
            this.panDescription.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(47, 22);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(0);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(342, 44);
            this.txtDescription.TabIndex = 1;
            this.txtDescription.Tag = "";
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDescription.ForeColor = System.Drawing.Color.DimGray;
            this.lblDescription.Location = new System.Drawing.Point(22, 22);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.lblDescription.Size = new System.Drawing.Size(25, 22);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "...";
            this.lblDescription.Click += new System.EventHandler(this.lblDescription_Click);
            // 
            // panAttended
            // 
            this.panAttended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panAttended.Controls.Add(this.txtAttended);
            this.panAttended.Controls.Add(this.lblAttended);
            this.panAttended.Dock = System.Windows.Forms.DockStyle.Top;
            this.panAttended.Location = new System.Drawing.Point(0, 88);
            this.panAttended.Margin = new System.Windows.Forms.Padding(0);
            this.panAttended.Name = "panAttended";
            this.panAttended.Padding = new System.Windows.Forms.Padding(22, 22, 22, 0);
            this.panAttended.Size = new System.Drawing.Size(411, 44);
            this.panAttended.TabIndex = 2;
            // 
            // txtAttended
            // 
            this.txtAttended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtAttended.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAttended.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtAttended.ForeColor = System.Drawing.Color.Black;
            this.txtAttended.Location = new System.Drawing.Point(47, 22);
            this.txtAttended.Margin = new System.Windows.Forms.Padding(0);
            this.txtAttended.Name = "txtAttended";
            this.txtAttended.Size = new System.Drawing.Size(342, 22);
            this.txtAttended.TabIndex = 1;
            this.txtAttended.Tag = "";
            this.txtAttended.TextChanged += new System.EventHandler(this.txtAttended_TextChanged);
            // 
            // lblAttended
            // 
            this.lblAttended.AutoSize = true;
            this.lblAttended.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblAttended.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAttended.ForeColor = System.Drawing.Color.DimGray;
            this.lblAttended.Location = new System.Drawing.Point(22, 22);
            this.lblAttended.Margin = new System.Windows.Forms.Padding(0);
            this.lblAttended.Name = "lblAttended";
            this.lblAttended.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.lblAttended.Size = new System.Drawing.Size(25, 22);
            this.lblAttended.TabIndex = 0;
            this.lblAttended.Text = "...";
            this.lblAttended.Click += new System.EventHandler(this.lblAttended_Click);
            // 
            // panPosition
            // 
            this.panPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panPosition.Controls.Add(this.txtPosition);
            this.panPosition.Controls.Add(this.lblPosition);
            this.panPosition.Dock = System.Windows.Forms.DockStyle.Top;
            this.panPosition.Location = new System.Drawing.Point(0, 44);
            this.panPosition.Margin = new System.Windows.Forms.Padding(0);
            this.panPosition.Name = "panPosition";
            this.panPosition.Padding = new System.Windows.Forms.Padding(22, 22, 22, 0);
            this.panPosition.Size = new System.Drawing.Size(411, 44);
            this.panPosition.TabIndex = 1;
            // 
            // txtPosition
            // 
            this.txtPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPosition.ForeColor = System.Drawing.Color.Black;
            this.txtPosition.Location = new System.Drawing.Point(47, 22);
            this.txtPosition.Margin = new System.Windows.Forms.Padding(0);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(342, 22);
            this.txtPosition.TabIndex = 1;
            this.txtPosition.Tag = "";
            this.txtPosition.TextChanged += new System.EventHandler(this.txtPosition_TextChanged);
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblPosition.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPosition.ForeColor = System.Drawing.Color.DimGray;
            this.lblPosition.Location = new System.Drawing.Point(22, 22);
            this.lblPosition.Margin = new System.Windows.Forms.Padding(0);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.lblPosition.Size = new System.Drawing.Size(25, 22);
            this.lblPosition.TabIndex = 0;
            this.lblPosition.Text = "...";
            this.lblPosition.Click += new System.EventHandler(this.lblPosition_Click);
            // 
            // panName
            // 
            this.panName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.panName.Controls.Add(this.txtName);
            this.panName.Controls.Add(this.lblName);
            this.panName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panName.Location = new System.Drawing.Point(0, 0);
            this.panName.Margin = new System.Windows.Forms.Padding(0);
            this.panName.Name = "panName";
            this.panName.Padding = new System.Windows.Forms.Padding(22, 22, 22, 0);
            this.panName.Size = new System.Drawing.Size(411, 44);
            this.panName.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(47, 22);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(342, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "";
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.lblName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblName.ForeColor = System.Drawing.Color.DimGray;
            this.lblName.Location = new System.Drawing.Point(22, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(0);
            this.lblName.Name = "lblName";
            this.lblName.Padding = new System.Windows.Forms.Padding(0, 0, 3, 1);
            this.lblName.Size = new System.Drawing.Size(25, 22);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "...";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // ucEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panShell);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ucEdit";
            this.Padding = new System.Windows.Forms.Padding(22, 22, 22, 0);
            this.Size = new System.Drawing.Size(455, 330);
            this.Load += new System.EventHandler(this.ucEdit_Load);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.panShell.ResumeLayout(false);
            this.panMessage.ResumeLayout(false);
            this.panMessage.PerformLayout();
            this.panContent.ResumeLayout(false);
            this.panDescription.ResumeLayout(false);
            this.panDescription.PerformLayout();
            this.panAttended.ResumeLayout(false);
            this.panAttended.PerformLayout();
            this.panPosition.ResumeLayout(false);
            this.panPosition.PerformLayout();
            this.panName.ResumeLayout(false);
            this.panName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Panel panShell;
        private System.Windows.Forms.Panel panAttended;
        private System.Windows.Forms.TextBox txtAttended;
        private System.Windows.Forms.Label lblAttended;
        private System.Windows.Forms.Panel panName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Label lblVisible;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Panel panPosition;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel panDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}
