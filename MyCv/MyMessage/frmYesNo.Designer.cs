namespace MyCv.MyMessage
{
    partial class frmYesNo
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
            this.lblContent = new System.Windows.Forms.Label();
            this.panIconAndContent = new System.Windows.Forms.Panel();
            this.lblIcon = new System.Windows.Forms.Label();
            this.panHeader = new System.Windows.Forms.Panel();
            this.lblOk = new System.Windows.Forms.Label();
            this.lblYes = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblCancel = new System.Windows.Forms.Label();
            this.panFooter = new System.Windows.Forms.Panel();
            this.panIconAndContent.SuspendLayout();
            this.panHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContent
            // 
            this.lblContent.BackColor = System.Drawing.Color.LightGray;
            this.lblContent.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblContent.ForeColor = System.Drawing.Color.Black;
            this.lblContent.Location = new System.Drawing.Point(86, 3);
            this.lblContent.Margin = new System.Windows.Forms.Padding(0);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(535, 74);
            this.lblContent.TabIndex = 1;
            this.lblContent.Text = "...";
            this.lblContent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panIconAndContent
            // 
            this.panIconAndContent.BackColor = System.Drawing.Color.Gainsboro;
            this.panIconAndContent.Controls.Add(this.lblContent);
            this.panIconAndContent.Controls.Add(this.lblIcon);
            this.panIconAndContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panIconAndContent.Location = new System.Drawing.Point(0, 80);
            this.panIconAndContent.Margin = new System.Windows.Forms.Padding(0);
            this.panIconAndContent.Name = "panIconAndContent";
            this.panIconAndContent.Padding = new System.Windows.Forms.Padding(3);
            this.panIconAndContent.Size = new System.Drawing.Size(624, 80);
            this.panIconAndContent.TabIndex = 1;
            // 
            // lblIcon
            // 
            this.lblIcon.BackColor = System.Drawing.Color.LightGray;
            this.lblIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblIcon.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIcon.ForeColor = System.Drawing.Color.Black;
            this.lblIcon.Location = new System.Drawing.Point(3, 3);
            this.lblIcon.Margin = new System.Windows.Forms.Padding(0);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(80, 74);
            this.lblIcon.TabIndex = 0;
            this.lblIcon.Text = "?";
            this.lblIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panHeader
            // 
            this.panHeader.BackColor = System.Drawing.Color.Gray;
            this.panHeader.Controls.Add(this.lblOk);
            this.panHeader.Controls.Add(this.lblYes);
            this.panHeader.Controls.Add(this.lblNo);
            this.panHeader.Controls.Add(this.lblHeading);
            this.panHeader.Controls.Add(this.lblCancel);
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
            this.lblOk.Location = new System.Drawing.Point(304, 0);
            this.lblOk.Margin = new System.Windows.Forms.Padding(0);
            this.lblOk.Name = "lblOk";
            this.lblOk.Size = new System.Drawing.Size(80, 80);
            this.lblOk.TabIndex = 1;
            this.lblOk.Text = "...";
            this.lblOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOk.Visible = false;
            this.lblOk.Click += new System.EventHandler(this.lblOk_Click);
            this.lblOk.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOk_MouseDown);
            this.lblOk.MouseEnter += new System.EventHandler(this.lblOk_MouseEnter);
            this.lblOk.MouseLeave += new System.EventHandler(this.lblOk_MouseLeave);
            // 
            // lblYes
            // 
            this.lblYes.BackColor = System.Drawing.Color.Gray;
            this.lblYes.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblYes.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblYes.Location = new System.Drawing.Point(384, 0);
            this.lblYes.Margin = new System.Windows.Forms.Padding(0);
            this.lblYes.Name = "lblYes";
            this.lblYes.Size = new System.Drawing.Size(80, 80);
            this.lblYes.TabIndex = 2;
            this.lblYes.Text = "...";
            this.lblYes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblYes.Visible = false;
            this.lblYes.Click += new System.EventHandler(this.lblYes_Click);
            this.lblYes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblYes_MouseDown);
            this.lblYes.MouseEnter += new System.EventHandler(this.lblYes_MouseEnter);
            this.lblYes.MouseLeave += new System.EventHandler(this.lblYes_MouseLeave);
            // 
            // lblNo
            // 
            this.lblNo.BackColor = System.Drawing.Color.Gray;
            this.lblNo.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNo.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNo.Location = new System.Drawing.Point(464, 0);
            this.lblNo.Margin = new System.Windows.Forms.Padding(0);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(80, 80);
            this.lblNo.TabIndex = 3;
            this.lblNo.Text = "...";
            this.lblNo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNo.Visible = false;
            this.lblNo.Click += new System.EventHandler(this.lblNo_Click);
            this.lblNo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNo_MouseDown);
            this.lblNo.MouseEnter += new System.EventHandler(this.lblNo_MouseEnter);
            this.lblNo.MouseLeave += new System.EventHandler(this.lblNo_MouseLeave);
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblHeading.Location = new System.Drawing.Point(21, 30);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(22, 21);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "...";
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
            this.lblCancel.TabIndex = 4;
            this.lblCancel.Text = "...";
            this.lblCancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCancel.Visible = false;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblCancel_MouseDown);
            this.lblCancel.MouseEnter += new System.EventHandler(this.lblCancel_MouseEnter);
            this.lblCancel.MouseLeave += new System.EventHandler(this.lblCancel_MouseLeave);
            // 
            // panFooter
            // 
            this.panFooter.BackColor = System.Drawing.Color.Gray;
            this.panFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panFooter.Location = new System.Drawing.Point(0, 160);
            this.panFooter.Margin = new System.Windows.Forms.Padding(0);
            this.panFooter.Name = "panFooter";
            this.panFooter.Padding = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.panFooter.Size = new System.Drawing.Size(624, 25);
            this.panFooter.TabIndex = 2;
            // 
            // frmYesNo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(624, 185);
            this.Controls.Add(this.panIconAndContent);
            this.Controls.Add(this.panHeader);
            this.Controls.Add(this.panFooter);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYesNo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "...";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmYesNo_FormClosing);
            this.Load += new System.EventHandler(this.frmYesNo_Load);
            this.panIconAndContent.ResumeLayout(false);
            this.panHeader.ResumeLayout(false);
            this.panHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblContent;
        private System.Windows.Forms.Panel panIconAndContent;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.Panel panHeader;
        private System.Windows.Forms.Label lblYes;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel panFooter;
        private System.Windows.Forms.Label lblOk;
        private System.Windows.Forms.Label lblCancel;
    }
}