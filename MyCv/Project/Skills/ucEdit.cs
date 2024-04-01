using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.Skills
{
    public partial class ucEdit : UserControl
    {
        //class
        Library.clsString Strings = new Library.clsString();
        Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private DataTable table = Library.clsData.Skills;

        //property
        public int ID { get; set; } = 0;
        public string SkillType { get; set; } = "";
        public string sName { get; set; } = "";
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

            OptionButtonColor();

            UserControlHeightSet();

            txtName.Focus();
            txtName.SelectAll();
        }

        //mouseClickEvent
        private void lblHeading_Click(object sender, EventArgs e)
        {
            HideShowMessageOrSkillType(flpSkillType, lblHeading);

            if (flpSkillType.Visible == false)
            {
                lblHeading.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);
            }

            UserControlHeightSet();
        }

        private void lblOption1_Click(object sender, EventArgs e)
        {
            OptionSelect(lblOption1.Text);
        }

        private void lblOption2_Click(object sender, EventArgs e)
        {
            OptionSelect(lblOption2.Text);
        }

        private void lblOption3_Click(object sender, EventArgs e)
        {
            OptionSelect(lblOption3.Text);
        }

        private void lblOption4_Click(object sender, EventArgs e)
        {
            OptionSelect(lblOption4.Text);
        }

        private void lblVisible_Click(object sender, EventArgs e)
        {
            HideShowContent();

            UserControlHeightSet();

            SaveVisibleData();
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            HideShowMessageOrSkillType(panMessage, lblRemove);

            if (panMessage.Visible == false)
            {
                lblRemove.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);
            }

            UserControlHeightSet();
        }

        private void lblYes_Click(object sender, EventArgs e)
        {
            Yes();
        }

        private void lblNo_Click(object sender, EventArgs e)
        {
            HideShowMessageOrSkillType(panMessage, lblRemove);

            UserControlHeightSet();
        }

        private void lblName_Click(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.SelectAll();
        }

        //mouseDownEvent
        private void lblHeading_MouseDown(object sender, MouseEventArgs e)
        {
            if (flpSkillType.Visible == false)
            {
                lblHeading.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
            }
        }

        private void lblOption1_MouseDown(object sender, MouseEventArgs e)
        {
            if (SkillType != lblOption1.Text)
            {
                lblOption1.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
            }
        }

        private void lblOption2_MouseDown(object sender, MouseEventArgs e)
        {
            if (SkillType != lblOption2.Text)
            {
                lblOption2.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
            }
        }

        private void lblOption3_MouseDown(object sender, MouseEventArgs e)
        {
            if (SkillType != lblOption3.Text)
            {
                lblOption3.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
            }
        }

        private void lblOption4_MouseDown(object sender, MouseEventArgs e)
        {
            if (SkillType != lblOption4.Text)
            {
                lblOption4.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 3);
            }
        }

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
        private void lblHeading_MouseEnter(object sender, EventArgs e)
        {
            if (flpSkillType.Visible == false)
            {
                lblHeading.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);
            }

            Tooltip.Show(1, Strings.Set("Slill Type", "", ""));
        }

        private void lblOption1_MouseEnter(object sender, EventArgs e)
        {
            if (SkillType != lblOption1.Text)
            {
                lblOption1.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);
            }

            Tooltip.Show(1, lblOption1.Text);
        }

        private void lblOption2_MouseEnter(object sender, EventArgs e)
        {
            if (SkillType != lblOption2.Text)
            {
                lblOption2.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);
            }

            Tooltip.Show(1, lblOption2.Text);
        }

        private void lblOption3_MouseEnter(object sender, EventArgs e)
        {
            if (SkillType != lblOption3.Text)
            {
                lblOption3.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);
            }

            Tooltip.Show(1, lblOption3.Text);
        }

        private void lblOption4_MouseEnter(object sender, EventArgs e)
        {
            if (SkillType != lblOption4.Text)
            {
                lblOption4.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 3);
            }

            Tooltip.Show(1, lblOption4.Text);
        }

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
        private void lblHeading_MouseLeave(object sender, EventArgs e)
        {
            if (flpSkillType.Visible == false)
            {
                lblHeading.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);
            }

            Tooltip.Show();
        }

        private void lblOption1_MouseLeave(object sender, EventArgs e)
        {
            if(SkillType != lblOption1.Text)
            {
                lblOption1.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            }

            Tooltip.Show();
        }

        private void lblOption2_MouseLeave(object sender, EventArgs e)
        {
            if (SkillType != lblOption2.Text)
            {
                lblOption2.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            }

            Tooltip.Show();
        }

        private void lblOption3_MouseLeave(object sender, EventArgs e)
        {
            if (SkillType != lblOption3.Text)
            {
                lblOption3.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            }

            Tooltip.Show();
        }

        private void lblOption4_MouseLeave(object sender, EventArgs e)
        {
            if (SkillType != lblOption4.Text)
            {
                lblOption4.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            }

            Tooltip.Show();
        }

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
            sName = txtName.Text;

            SaveStringData("Name", sName);
        }

        //sizeChangedEvent
        private void panHeader_SizeChanged(object sender, EventArgs e)
        {
            UserControlHeightSet();
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            lblHeading.Text = SkillType;
            txtName.Text = sName;
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

        private void OptionSelect(string optionValue)
        {
            SkillType = optionValue;

            OptionButtonColor();

            HideShowMessageOrSkillType(flpSkillType, lblHeading);

            UserControlHeightSet();

            lblHeading.Text = SkillType;

            SaveStringData("SkillType", SkillType);
        }

        private void OptionButtonColor()
        {
            lblOption1.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            lblOption2.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            lblOption3.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);
            lblOption4.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 3);

            if (SkillType == lblOption1.Text)
            {
                lblOption1.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseClick, 3);
            }
            else if (SkillType == lblOption2.Text)
            {
                lblOption2.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseClick, 3);
            }
            else if (SkillType == lblOption3.Text)
            {
                lblOption3.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseClick, 3);
            }
            else if (SkillType == lblOption4.Text)
            {
                lblOption4.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseClick, 3);
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

        private void HideShowMessageOrSkillType(Panel panel, Label label)
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

            if(flpSkillType.Visible == true)
            {
                Height = Height + flpSkillType.Height;
            }

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
            lblSkillType.Text = Strings.Set("Skill Type:", "", "");
            lblOption1.Text = Strings.Set("Software", "", "");
            lblOption2.Text = Strings.Set("Programming languages", "", "");
            lblOption3.Text = Strings.Set("Foreign languages", "", "");
            lblOption4.Text = Strings.Set("Other", "", "");
            lblRemove.Text = Strings.Set("Remove", "", "");
            lblMessage.Text = Strings.Set("Do you wish to remove this card?", "", "");
            lblYes.Text = Strings.Set("Yes", "Да", "Da");
            lblNo.Text = Strings.Set("No", "Не", "Ne");
            lblName.Text = Strings.Set("Name:", "", "");

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