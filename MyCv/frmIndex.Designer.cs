namespace MyCv
{
    partial class frmIndex
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblProject = new System.Windows.Forms.Label();
            this.panProjectShell = new System.Windows.Forms.Panel();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.panProjectAndMessage = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.panMenuAndProjectShell = new System.Windows.Forms.Panel();
            this.panProjectMenu = new System.Windows.Forms.Panel();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblRename = new System.Windows.Forms.Label();
            this.lblOpen = new System.Windows.Forms.Label();
            this.lblNew = new System.Windows.Forms.Label();
            this.panMenu = new System.Windows.Forms.Panel();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblPrint = new System.Windows.Forms.Label();
            this.lblSave = new System.Windows.Forms.Label();
            this.panContentShell = new System.Windows.Forms.Panel();
            this.panContent = new System.Windows.Forms.Panel();
            this.timMessage = new System.Windows.Forms.Timer(this.components);
            this.panProjectShell.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.panProjectAndMessage.SuspendLayout();
            this.panMenuAndProjectShell.SuspendLayout();
            this.panProjectMenu.SuspendLayout();
            this.panMenu.SuspendLayout();
            this.panContentShell.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProject
            // 
            this.lblProject.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblProject.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblProject.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblProject.Location = new System.Drawing.Point(0, 3);
            this.lblProject.Margin = new System.Windows.Forms.Padding(0);
            this.lblProject.Name = "lblProject";
            this.lblProject.Padding = new System.Windows.Forms.Padding(15, 0, 15, 10);
            this.lblProject.Size = new System.Drawing.Size(119, 74);
            this.lblProject.TabIndex = 0;
            this.lblProject.Text = "...";
            this.lblProject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panProjectShell
            // 
            this.panProjectShell.BackColor = System.Drawing.Color.Gray;
            this.panProjectShell.Controls.Add(this.dgvView);
            this.panProjectShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panProjectShell.Location = new System.Drawing.Point(3, 243);
            this.panProjectShell.Margin = new System.Windows.Forms.Padding(0);
            this.panProjectShell.Name = "panProjectShell";
            this.panProjectShell.Padding = new System.Windows.Forms.Padding(0, 3, 0, 25);
            this.panProjectShell.Size = new System.Drawing.Size(317, 438);
            this.panProjectShell.TabIndex = 1;
            // 
            // dgvView
            // 
            this.dgvView.AllowUserToAddRows = false;
            this.dgvView.AllowUserToDeleteRows = false;
            this.dgvView.AllowUserToResizeColumns = false;
            this.dgvView.AllowUserToResizeRows = false;
            this.dgvView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvView.BackgroundColor = System.Drawing.Color.White;
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvView.EnableHeadersVisualStyles = false;
            this.dgvView.GridColor = System.Drawing.Color.LightGray;
            this.dgvView.Location = new System.Drawing.Point(0, 3);
            this.dgvView.Margin = new System.Windows.Forms.Padding(0);
            this.dgvView.MultiSelect = false;
            this.dgvView.Name = "dgvView";
            this.dgvView.ReadOnly = true;
            this.dgvView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvView.RowHeadersVisible = false;
            this.dgvView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.dgvView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvView.ShowCellToolTips = false;
            this.dgvView.Size = new System.Drawing.Size(317, 410);
            this.dgvView.TabIndex = 0;
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            this.dgvView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvView_KeyDown);
            // 
            // panProjectAndMessage
            // 
            this.panProjectAndMessage.Controls.Add(this.lblMessage);
            this.panProjectAndMessage.Controls.Add(this.lblProject);
            this.panProjectAndMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProjectAndMessage.Location = new System.Drawing.Point(3, 83);
            this.panProjectAndMessage.Margin = new System.Windows.Forms.Padding(0);
            this.panProjectAndMessage.Name = "panProjectAndMessage";
            this.panProjectAndMessage.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.panProjectAndMessage.Size = new System.Drawing.Size(317, 80);
            this.panProjectAndMessage.TabIndex = 0;
            // 
            // lblMessage
            // 
            this.lblMessage.BackColor = System.Drawing.Color.Gray;
            this.lblMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMessage.Font = new System.Drawing.Font("Segoe UI Light", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMessage.ForeColor = System.Drawing.Color.Lavender;
            this.lblMessage.Location = new System.Drawing.Point(119, 3);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblMessage.Size = new System.Drawing.Size(198, 74);
            this.lblMessage.TabIndex = 1;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panMenuAndProjectShell
            // 
            this.panMenuAndProjectShell.BackColor = System.Drawing.Color.Gray;
            this.panMenuAndProjectShell.Controls.Add(this.panProjectShell);
            this.panMenuAndProjectShell.Controls.Add(this.panProjectMenu);
            this.panMenuAndProjectShell.Controls.Add(this.panProjectAndMessage);
            this.panMenuAndProjectShell.Controls.Add(this.panMenu);
            this.panMenuAndProjectShell.Dock = System.Windows.Forms.DockStyle.Left;
            this.panMenuAndProjectShell.Location = new System.Drawing.Point(0, 0);
            this.panMenuAndProjectShell.Margin = new System.Windows.Forms.Padding(0);
            this.panMenuAndProjectShell.Name = "panMenuAndProjectShell";
            this.panMenuAndProjectShell.Padding = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.panMenuAndProjectShell.Size = new System.Drawing.Size(320, 681);
            this.panMenuAndProjectShell.TabIndex = 0;
            // 
            // panProjectMenu
            // 
            this.panProjectMenu.Controls.Add(this.lblRemove);
            this.panProjectMenu.Controls.Add(this.lblRename);
            this.panProjectMenu.Controls.Add(this.lblOpen);
            this.panProjectMenu.Controls.Add(this.lblNew);
            this.panProjectMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panProjectMenu.Location = new System.Drawing.Point(3, 163);
            this.panProjectMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panProjectMenu.Name = "panProjectMenu";
            this.panProjectMenu.Size = new System.Drawing.Size(317, 80);
            this.panProjectMenu.TabIndex = 1;
            // 
            // lblRemove
            // 
            this.lblRemove.BackColor = System.Drawing.Color.DimGray;
            this.lblRemove.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRemove.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRemove.Location = new System.Drawing.Point(240, 0);
            this.lblRemove.Margin = new System.Windows.Forms.Padding(0);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(80, 80);
            this.lblRemove.TabIndex = 3;
            this.lblRemove.Text = "...";
            this.lblRemove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRemove.Click += new System.EventHandler(this.lblRemove_Click);
            this.lblRemove.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRemove_MouseDown);
            this.lblRemove.MouseEnter += new System.EventHandler(this.lblRemove_MouseEnter);
            this.lblRemove.MouseLeave += new System.EventHandler(this.lblRemove_MouseLeave);
            // 
            // lblRename
            // 
            this.lblRename.BackColor = System.Drawing.Color.DimGray;
            this.lblRename.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblRename.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblRename.Location = new System.Drawing.Point(160, 0);
            this.lblRename.Margin = new System.Windows.Forms.Padding(0);
            this.lblRename.Name = "lblRename";
            this.lblRename.Size = new System.Drawing.Size(80, 80);
            this.lblRename.TabIndex = 2;
            this.lblRename.Text = "...";
            this.lblRename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblRename.Click += new System.EventHandler(this.lblRename_Click);
            this.lblRename.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblRename_MouseDown);
            this.lblRename.MouseEnter += new System.EventHandler(this.lblRename_MouseEnter);
            this.lblRename.MouseLeave += new System.EventHandler(this.lblRename_MouseLeave);
            // 
            // lblOpen
            // 
            this.lblOpen.BackColor = System.Drawing.Color.DimGray;
            this.lblOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblOpen.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblOpen.Location = new System.Drawing.Point(80, 0);
            this.lblOpen.Margin = new System.Windows.Forms.Padding(0);
            this.lblOpen.Name = "lblOpen";
            this.lblOpen.Size = new System.Drawing.Size(80, 80);
            this.lblOpen.TabIndex = 1;
            this.lblOpen.Text = "...";
            this.lblOpen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOpen.Click += new System.EventHandler(this.lblOpen_Click);
            this.lblOpen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblOpen_MouseDown);
            this.lblOpen.MouseEnter += new System.EventHandler(this.lblOpen_MouseEnter);
            this.lblOpen.MouseLeave += new System.EventHandler(this.lblOpen_MouseLeave);
            // 
            // lblNew
            // 
            this.lblNew.BackColor = System.Drawing.Color.DimGray;
            this.lblNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblNew.Location = new System.Drawing.Point(0, 0);
            this.lblNew.Margin = new System.Windows.Forms.Padding(0);
            this.lblNew.Name = "lblNew";
            this.lblNew.Size = new System.Drawing.Size(80, 80);
            this.lblNew.TabIndex = 0;
            this.lblNew.Text = "...";
            this.lblNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNew.Click += new System.EventHandler(this.lblNew_Click);
            this.lblNew.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblNew_MouseDown);
            this.lblNew.MouseEnter += new System.EventHandler(this.lblNew_MouseEnter);
            this.lblNew.MouseLeave += new System.EventHandler(this.lblNew_MouseLeave);
            // 
            // panMenu
            // 
            this.panMenu.Controls.Add(this.lblLanguage);
            this.panMenu.Controls.Add(this.lblAuthor);
            this.panMenu.Controls.Add(this.lblPrint);
            this.panMenu.Controls.Add(this.lblSave);
            this.panMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panMenu.Location = new System.Drawing.Point(3, 3);
            this.panMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panMenu.Name = "panMenu";
            this.panMenu.Size = new System.Drawing.Size(317, 80);
            this.panMenu.TabIndex = 0;
            // 
            // lblLanguage
            // 
            this.lblLanguage.BackColor = System.Drawing.Color.DimGray;
            this.lblLanguage.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblLanguage.Location = new System.Drawing.Point(240, 0);
            this.lblLanguage.Margin = new System.Windows.Forms.Padding(0);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(80, 80);
            this.lblLanguage.TabIndex = 3;
            this.lblLanguage.Text = "...";
            this.lblLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLanguage.Click += new System.EventHandler(this.lblLanguage_Click);
            this.lblLanguage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblLanguage_MouseDown);
            this.lblLanguage.MouseEnter += new System.EventHandler(this.lblLanguage_MouseEnter);
            this.lblLanguage.MouseLeave += new System.EventHandler(this.lblLanguage_MouseLeave);
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.DimGray;
            this.lblAuthor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblAuthor.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAuthor.Location = new System.Drawing.Point(160, 0);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(80, 80);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "...";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAuthor.Click += new System.EventHandler(this.lblAuthor_Click);
            this.lblAuthor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblAuthor_MouseDown);
            this.lblAuthor.MouseEnter += new System.EventHandler(this.lblAuthor_MouseEnter);
            this.lblAuthor.MouseLeave += new System.EventHandler(this.lblAuthor_MouseLeave);
            // 
            // lblPrint
            // 
            this.lblPrint.BackColor = System.Drawing.Color.DimGray;
            this.lblPrint.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPrint.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblPrint.Location = new System.Drawing.Point(80, 0);
            this.lblPrint.Margin = new System.Windows.Forms.Padding(0);
            this.lblPrint.Name = "lblPrint";
            this.lblPrint.Size = new System.Drawing.Size(80, 80);
            this.lblPrint.TabIndex = 1;
            this.lblPrint.Text = "...";
            this.lblPrint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPrint.Click += new System.EventHandler(this.lblPrint_Click);
            this.lblPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblPrint_MouseDown);
            this.lblPrint.MouseEnter += new System.EventHandler(this.lblPrint_MouseEnter);
            this.lblPrint.MouseLeave += new System.EventHandler(this.lblPrint_MouseLeave);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.DimGray;
            this.lblSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSave.Location = new System.Drawing.Point(0, 0);
            this.lblSave.Margin = new System.Windows.Forms.Padding(0);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(80, 80);
            this.lblSave.TabIndex = 0;
            this.lblSave.Text = "...";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            this.lblSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSave_MouseDown);
            this.lblSave.MouseEnter += new System.EventHandler(this.lblSave_MouseEnter);
            this.lblSave.MouseLeave += new System.EventHandler(this.lblSave_MouseLeave);
            // 
            // panContentShell
            // 
            this.panContentShell.BackColor = System.Drawing.Color.Gray;
            this.panContentShell.Controls.Add(this.panContent);
            this.panContentShell.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContentShell.Location = new System.Drawing.Point(320, 0);
            this.panContentShell.Margin = new System.Windows.Forms.Padding(0);
            this.panContentShell.Name = "panContentShell";
            this.panContentShell.Padding = new System.Windows.Forms.Padding(3, 3, 3, 25);
            this.panContentShell.Size = new System.Drawing.Size(624, 681);
            this.panContentShell.TabIndex = 1;
            // 
            // panContent
            // 
            this.panContent.BackColor = System.Drawing.Color.DimGray;
            this.panContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panContent.Location = new System.Drawing.Point(3, 3);
            this.panContent.Margin = new System.Windows.Forms.Padding(0);
            this.panContent.Name = "panContent";
            this.panContent.Size = new System.Drawing.Size(618, 653);
            this.panContent.TabIndex = 0;
            // 
            // timMessage
            // 
            this.timMessage.Interval = 1000;
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.panContentShell);
            this.Controls.Add(this.panMenuAndProjectShell);
            this.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "frmIndex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyCv";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmIndex_FormClosing);
            this.Load += new System.EventHandler(this.frmIndex_Load);
            this.Shown += new System.EventHandler(this.frmIndex_Shown);
            this.panProjectShell.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.panProjectAndMessage.ResumeLayout(false);
            this.panMenuAndProjectShell.ResumeLayout(false);
            this.panProjectMenu.ResumeLayout(false);
            this.panMenu.ResumeLayout(false);
            this.panContentShell.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProject;
        private System.Windows.Forms.Panel panProjectShell;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Panel panProjectAndMessage;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel panMenuAndProjectShell;
        private System.Windows.Forms.Panel panProjectMenu;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblRename;
        private System.Windows.Forms.Label lblOpen;
        private System.Windows.Forms.Label lblNew;
        private System.Windows.Forms.Panel panMenu;
        private System.Windows.Forms.Label lblLanguage;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblPrint;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Panel panContentShell;
        private System.Windows.Forms.Panel panContent;
        private System.Windows.Forms.Timer timMessage;
    }
}

