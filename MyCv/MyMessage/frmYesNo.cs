using System;
using System.Windows.Forms;

namespace MyCv.MyMessage
{
    public partial class frmYesNo : Form
    {
        //class
        private clsOptions Options = new clsOptions();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();

        //property
        public int MessageType { get; set; } = 0;
        public int Result { get; set; } = 0;
        public string Caption { set { Text = value; } }
        public string Heading { set { lblHeading.Text = value; } }
        public string IconText { set { lblIcon.Text = value; } }
        public string Message { set { lblContent.Text = value; } }

        //constructor
        public frmYesNo()
        {
            InitializeComponent();
        }

        //formEvent
        private void frmYesNo_Load(object sender, EventArgs e)
        {
            SetControlsText();

            FormSet();
        }

        private void frmYesNo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Result == 0)
            {
                Cancel();
            }
        }

        //mouseClickEvent
        private void lblOk_Click(object sender, EventArgs e)
        {
            Result = Options.OK;
            Close();
        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            Result = Options.Yes;
            Close();
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            Result = Options.No;
            Close();
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Result = Options.Cancel;
            Close();
        }

        //mouseDownEvent
        private void lblOk_MouseDown(object sender, MouseEventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
        }

        private void lblYes_MouseDown(object sender, MouseEventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);    
        }

        private void lblNo_MouseDown(object sender, MouseEventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
        }

        private void lblCancel_MouseDown(object sender, MouseEventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
        }

        //mouseEnterEvent
        private void lblOk_MouseEnter(object sender, EventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        private void lblYes_MouseEnter(object sender, EventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        private void lblNo_MouseEnter(object sender, EventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        //mouseLeaveEvent
        private void lblOk_MouseLeave(object sender, EventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        private void lblYes_MouseLeave(object sender, EventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        private void lblNo_MouseLeave(object sender, EventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        #region methodsAndFunctions
        //methods
        private void FormSet()
        {
            if (MessageType == Options.OKOnly)
            {
                lblOk.Visible = true;
            }
            else if (MessageType == Options.YesNo)
            {
                lblYes.Visible = true;
                lblNo.Visible = true;
            }
            else if (MessageType == Options.YesNoCancel)
            {
                lblYes.Visible = true;
                lblNo.Visible = true;
                lblCancel.Visible = true;
            }
        }

        private void Accept()
        {
            if (MessageType == Options.OKOnly)
            {
                Result = Options.OK;
            }
            else if (MessageType == Options.YesNo)
            {
                Result = Options.Yes;
            }
            else if (MessageType == Options.YesNoCancel)
            {
                Result = Options.Yes;
            }
        }

        private void Cancel()
        {
            if (MessageType == Options.OKOnly)
            {
                Result = Options.OK;
            }
            else if (MessageType == Options.YesNo)
            {
                Result = Options.No;
            }
            else if (MessageType == Options.YesNoCancel)
            {
                Result = Options.Cancel;
            }
        }

        private void SetControlsText()
        {
            Library.clsString Strings = new Library.clsString();

            lblOk.Text = Strings.Set("OK", "OK", "OK");
            lblYes.Text = Strings.Set("Yes", "Да", "Da");
            lblNo.Text = Strings.Set("No", "Не", "Ne");
            lblCancel.Text = Strings.Set("Cancel", "Откажи", "Otkaži");
        }

        //functions
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                Accept();
                Close();
                return true;
            }
            else if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Cancel();
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}