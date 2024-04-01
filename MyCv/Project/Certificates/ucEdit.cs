using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.Certificates
{
    public partial class ucEdit : UserControl
    {
        //class
        Library.clsString Strings = new Library.clsString();
        Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private DataTable table = Library.clsData.Certificates;

        //property
        public Label LblHeading { get { return lblHeading; } }
        public int ID { get; set; } = 0;
        public string cName { get; set; } = "";
        public string Attended { get; set; } = "";
        public bool VisibleContent { get; set; } = true;

        //constructor
        public ucEdit()
        {
            InitializeComponent();
        }

        //formEvent
        private void ucEdit_Load(object sender, EventArgs e)
        {
            SetControlsText();

            LoadData();

            UserControlHeightSet();

            txtName.Focus();
            txtName.SelectAll();
        }

        //mouseClickEvent
        private void lblVisible_Click(object sender, EventArgs e)
        {
            HideShowContent();

            UserControlHeightSet();

            SaveVisibleData();
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            

            HideShowMessage(panMessage, lblRemove);

            if (panMessage.Visible == false)
            {
                lblRemove.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);
            }

            UserControlHeightSet();    
        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            Library.clsCardNumber CardNumber = new Library.clsCardNumber();

            Yes();

            CardNumber.Set(Library.clsFormsAndUserControls.UcCertificatesView.PanContent, 
                           Strings.Set("Certificates N°", "Сертификати БР", "Sertifikati BR"));
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            HideShowMessage(panMessage, lblRemove);

            UserControlHeightSet();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.SelectAll();
        }

        private void lblAttended_Click(object sender, EventArgs e)
        {
            txtAttended.Focus();
            txtAttended.SelectAll();
        }

        //mouseDownEvent
        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {

            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
        }

        private void lblRemove_MouseDown(object sender, MouseEventArgs e)
        {
            if (panMessage.Visible == false)
            {
                lblRemove.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
            }
        }

        private void lblYes_MouseDown(object sender, MouseEventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
        }

        private void lblNo_MouseDown(object sender, MouseEventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
        }

        //mouseEnterEvent
        private void lblVisible_MouseEnter(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);

            Tooltip.Show(1, Strings.Set("Hide/Show content", "", ""));
        }

        private void lblRemove_MouseEnter(object sender, EventArgs e)
        {
            if (panMessage.Visible == false)
            {
                lblRemove.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);
            }

            Tooltip.Show(1, Strings.Set("Remove card", "", ""));
        }

        private void lblYes_MouseEnter(object sender, EventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);

            Tooltip.Show(1, Strings.Set("Conform remove card.", "", ""));
        }

        private void lblNo_MouseEnter(object sender, EventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);

            Tooltip.Show(1, Strings.Set("Cancel remove card.", "", ""));
        }

        //mouseLeaveEvent
        private void lblVisible_MouseLeave(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);

            Tooltip.Show();
        }

        private void lblRemove_MouseLeave(object sender, EventArgs e)
        {
            if (panMessage.Visible == false)
            {
                lblRemove.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);
            }

            Tooltip.Show();
        }

        private void lblYes_MouseLeave(object sender, EventArgs e)
        {
            lblYes.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);

            Tooltip.Show();
        }

        private void lblNo_MouseLeave(object sender, EventArgs e)
        {
            lblNo.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);

            Tooltip.Show();
        }

        //textChangedEvent
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            cName = txtName.Text;

            SaveStringData("Name", cName);
        }

        private void txtAttended_TextChanged(object sender, EventArgs e)
        {
            Attended = txtAttended.Text;

            SaveStringData("Attended", Attended);
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            txtName.Text = cName;
            txtAttended.Text = Attended;
            panContent.Visible = VisibleContent;
        }

        private void SaveStringData(string columnName, string value)
        {
            DataRow row = table.Rows.Find(ID);

            if (row != null)
            {
                row[columnName] = value;
            }
        }

        private void SaveVisibleData()
        {
            DataRow row = table.Rows.Find(ID);

            if (row != null)
            {
                row["Visible"] = VisibleContent;
            }
        }

        private void Yes()
        {
            DataRow row = table.Rows.Find(ID);

            if (row != null)
            {
                row.Delete();
                Dispose();
            }
        }

        private void HideShowMessage(Panel panel, Label label)
        {
            if (panel.Visible == true)
            {
                label.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);
                panel.Visible = false;
            }
            else
            {
                label.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseClick, 1);
                panel.Visible = true;
            }
        }

        private void HideShowContent(int action = 0)
        {
            if (VisibleContent == true)
            {
                lblVisible.Text = Strings.Set("Show", "", "");
                VisibleContent = false;
            }
            else
            {
                lblVisible.Text = Strings.Set("Hide", "", "");
                VisibleContent = true;
            }

            panContent.Visible = VisibleContent;
        }

        private void UserControlHeightSet()
        {
            Height = 22 + panHeader.Height;

            if (panMessage.Visible == true)
            {
                Height = Height + panMessage.Height;
            }

            if (panContent.Visible == true)
            {
                Height = Height + panContent.Height;
            }
        }

        private void SetControlsText()
        {
            lblRemove.Text = Strings.Set("Remove", "", "");
            lblMessage.Text = Strings.Set("Do you wish to remove this card?", "", "");
            lblYes.Text = Strings.Set("Yes", "Да", "Da");
            lblNo.Text = Strings.Set("No", "Не", "Ne");
            lblName.Text = Strings.Set("Name:", "", "");
            lblAttended.Text = Strings.Set("Attended:", "", "");

            if (VisibleContent == true)
            {
                lblVisible.Text = Strings.Set("Hide", "", "");
            }
            else
            {
                lblVisible.Text = Strings.Set("Show", "", "");
            }
        }
        #endregion
    }
}