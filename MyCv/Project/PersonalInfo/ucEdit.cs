using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.PersonalInfo
{
    public partial class ucEdit : UserControl
    {
        //class
        Library.clsString Strings = new Library.clsString();
        Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private DataTable table = Library.clsData.PersonalInfo;

        //property
        public int ID { get; set; } = 0;
        public string piName { get; set; } = "";
        public string LastName { get; set; } = "";
        public string DateOfBirth { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
        public string Email { get; set; } = "";
        public string Title { get; set; } = "";
        public string BrieflyAboutYourself { get; set; } = "";
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

        private void lblName_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.SelectAll();
        }

        private void lblLastName_Click(object sender, EventArgs e)
        {
            txtLastName.Focus();
            txtLastName.SelectAll();
        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {
            txtDateOfBirth.Focus();
            txtDateOfBirth.SelectAll();
        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {
            txtPhoneNumber.Focus();
            txtPhoneNumber.SelectAll();
        }

        private void lblEmail_Click(object sender, EventArgs e)
        {
            txtEmail.Focus();
            txtEmail.SelectAll();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {
            txtTitle.Focus();
            txtTitle.SelectAll();
        }

        private void lblBrieflyAboutYourself_Click(object sender, EventArgs e)
        {
            txtBrieflyAboutYourself.Focus();
            txtBrieflyAboutYourself.SelectAll();
        }

        //mouseDownEvent
        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
        }

        //mouseEnterEvent
        private void lblVisible_MouseEnter(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);

            Tooltip.Show(1, Strings.Set("Hide/Show content.", "", ""));
        }

        //mouseLeaveEvent
        private void lblVisible_MouseLeave(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);

            Tooltip.Show();
        }

        //textChangedEvent
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            piName = txtName.Text;

            SaveStringData("Name", piName);
        }

        private void txtLastName_TextChanged(object sender, EventArgs e)
        {
            LastName = txtLastName.Text;

            SaveStringData("LastName", LastName);
        }

        private void txtDateOfBirth_TextChanged(object sender, EventArgs e)
        {
            DateOfBirth = txtDateOfBirth.Text;

            SaveStringData("DateOfBirth", DateOfBirth);
        }

        private void txtPhoneNumber_TextChanged(object sender, EventArgs e)
        {
            PhoneNumber = txtPhoneNumber.Text;

            SaveStringData("PhoneNumber", PhoneNumber);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            Email = txtEmail.Text;

            SaveStringData("Email", Email);
        }

        private void txtTitle_TextChanged(object sender, EventArgs e)
        {
            Title = txtTitle.Text;

            SaveStringData("Title", Title);
        }

        private void txtBrieflyAboutYourself_TextChanged(object sender, EventArgs e)
        {
            BrieflyAboutYourself = txtBrieflyAboutYourself.Text;

            SaveStringData("BrieflyAboutYourself", BrieflyAboutYourself);
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            txtName.Text = piName;
            txtLastName.Text = LastName;
            txtDateOfBirth.Text = DateOfBirth;
            txtPhoneNumber.Text = PhoneNumber;
            txtEmail.Text = Email;
            txtTitle.Text = Title;
            txtBrieflyAboutYourself.Text = BrieflyAboutYourself;
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

            if (panContent.Visible == true)
            {
                Height = Height + panContent.Height;
            }
        }

        private void SetControlsText()
        {
            lblName.Text = Strings.Set("Name:", "Име:", "Ime:");
            lblLastName.Text = Strings.Set("Last name:", "Презиме:", "Prezime:");
            lblDateOfBirth.Text = Strings.Set("Date of birth:", "Датум рођења:", "Datum rođenja:");
            lblPhoneNumber.Text = Strings.Set("Phone number:", "Број телефона:", "Broj telefona:");
            lblEmail.Text = Strings.Set("Email:", "Е-пошта:", "E-pošta:");
            lblTitle.Text = Strings.Set("Title:", "Звање:", "Zvanje:");
            lblBrieflyAboutYourself.Text = Strings.Set("Briefly about yourself:", "Укратко о себи:", "Ukratko o sebi:");

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