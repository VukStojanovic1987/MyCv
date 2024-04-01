using System;
using System.Windows.Forms;

namespace MyCv.Project
{
    public partial class frmView : Form
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        private Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private frmIndex frmIndex = Library.clsFormsAndUserControls.FrmIndex;

        private UserControl openUserControl = null;
        private Label selectedLabel = null;

        private int selectedIndex = 0;

        private const int none = 0;
        private const int profileImage = 1;
        private const int personalInfo = 2;
        private const int education = 3;
        private const int certificates = 4;
        private const int workExperiance = 5;
        private const int skills = 6;
        private const int coverLetters = 7;

        //constuctor
        public frmView()
        {
            InitializeComponent();
        }

        //formEvent
        private void frmView_Load(object sender, EventArgs e)
        {
            Library.clsFormsAndUserControls.FrmProjectView = this;

            SetControlsText();
        }

        //mouseClickEvent
        private void lblClose_Click(object sender, EventArgs e)
        {
            frmIndex.OpenProjectId = 0;
            frmIndex.LblProject.Dock = DockStyle.Left;
            frmIndex.LblMessage.Dock = DockStyle.Right;
            frmIndex.Text = "MyCv";
            Close();
        }

        private void lblProfileImage_Click(object sender, EventArgs e)
        {
            MenuSelect(new ProfileImage.ucView(), lblProfileImage, profileImage);
        }

        private void lblPersonalInfo_Click(object sender, EventArgs e)
        {
            MenuSelect(new PersonalInfo.ucView(), lblPersonalInfo, personalInfo);
        }

        private void lblEducation_Click(object sender, EventArgs e)
        {
            MenuSelect(new Education.ucView(), lblEducation, education);
        }

        private void lblCertificates_Click(object sender, EventArgs e)
        {
            MenuSelect(new Certificates.ucView(), lblCertificates, certificates);
        }

        private void lblWorkExperiance_Click(object sender, EventArgs e)
        {
            MenuSelect(new WorkExperience.ucView(), lblWorkExperiance, workExperiance);
        }

        private void lblSkills_Click(object sender, EventArgs e)
        {
            MenuSelect(new Skills.ucView(), lblSkills, skills);
        }

        private void lblCoverLetters_Click(object sender, EventArgs e)
        {
            MenuSelect(new CoverLetters.ucView(), lblCoverLetters, coverLetters);
        }

        //mouseDownEvent
        private void lblClose_MouseDown(object sender, MouseEventArgs e)
        {
            lblClose.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblProfileImage_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != profileImage)
            {
                lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblPersonalInfo_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != personalInfo)
            {
                lblPersonalInfo.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblEducation_MouseDown(object sender, MouseEventArgs e)
        {
            if(selectedIndex != education)
            {
                lblEducation.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblCertificates_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != certificates)
            {
                lblCertificates.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblWorkExperiance_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != workExperiance)
            {
                lblWorkExperiance.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblSkills_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != skills)
            {
                lblSkills.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        private void lblCoverLetters_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedIndex != coverLetters)
            {
                lblCoverLetters.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
            }
        }

        //mouseEnterEvent
        private void lblClose_MouseEnter(object sender, EventArgs e)
        {
            lblClose.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Close opened project", "", ""));
        }

        private void lblProfileImage_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != profileImage)
            {
                lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Profile Image", "", ""));
        }

        private void lblPersonalInfo_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != personalInfo)
            {
                lblPersonalInfo.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Personal Info", "", ""));
        }

        private void lblEducation_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != education)
            {
                lblEducation.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Education", "", ""));
        }

        private void lblCertificates_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != certificates)
            {
                lblCertificates.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Certificates", "", ""));
        }

        private void lblWorkExperiance_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != workExperiance)
            {
                lblWorkExperiance.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Work Experiance", "", ""));
        }

        private void lblSkills_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != skills)
            {
                lblSkills.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Skills", "", ""));
        }

        private void lblCoverLetters_MouseEnter(object sender, EventArgs e)
        {
            if (selectedIndex != coverLetters)
            {
                lblCoverLetters.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }

            Tooltip.Show(1, Strings.Set("Cover Letters", "", ""));
        }

        //mouseLeaveEvent
        private void lblClose_MouseLeave(object sender, EventArgs e)
        {
            lblClose.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblProfileImage_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != profileImage)
            {
                lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblPersonalInfo_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != personalInfo)
            {
                lblPersonalInfo.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblEducation_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != education)
            {
                lblEducation.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblCertificates_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != certificates)
            {
                lblCertificates.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblWorkExperiance_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != workExperiance)
            {
                lblWorkExperiance.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblSkills_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != skills)
            {
                lblSkills.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        private void lblCoverLetters_MouseLeave(object sender, EventArgs e)
        {
            if (selectedIndex != coverLetters)
            {
                lblCoverLetters.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }

            Tooltip.Show();
        }

        #region methodsAndFunctions
        //methods
        private void MenuSelect(UserControl userControl, Label label, int index)
        {
            if(openUserControl != null && label != null)
            {
                panContent.Controls.Remove(openUserControl);
                openUserControl = null;

                selectedLabel.BackColor = ButtonColor.Set(ButtonColor.Gray);
                selectedLabel = null;
            }

            if (selectedIndex == index)
            {
                selectedIndex = none;

                label.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
            }
            else
            {
                selectedIndex = index;

                openUserControl = userControl;
                openUserControl.Dock = DockStyle.Fill;
                panContent.Controls.Add(openUserControl);

                selectedLabel = label;
                selectedLabel.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseClick);
            }
        }

        private void SetControlsText()
        {
            lblClose.Text = Strings.Set("Close", "", "");
            lblProfileImage.Text = Strings.Set("Profile Image", "", "");
            lblPersonalInfo.Text = Strings.Set("Personal Info", "", "");
            lblEducation.Text = Strings.Set("Education", "", "");
            lblCertificates.Text = Strings.Set("Certificates", "", "");
            lblWorkExperiance.Text = Strings.Set("Work Experiance", "", "");
            lblSkills.Text = Strings.Set("Skills", "", "");
            lblCoverLetters.Text = Strings.Set("Cover Letters", "", "");
        }
        #endregion
    }
}