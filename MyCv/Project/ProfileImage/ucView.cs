using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.ProfileImage
{
    public partial class ucView : UserControl
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private DataTable table = Library.clsData.ProfileImage;
        private int id = 0;
        private bool visibleContent = true;

        //property

        //constructor
        public ucView()
        {
            InitializeComponent();
        }

        //userControlEvent
        private void ucView_Load(object sender, EventArgs e)
        {
            SetControlsText();

            LoadData();
        }

        //mouseClickEvent
        private void lblVisible_Click(object sender, EventArgs e)
        {
            HideShowContent();

            SaveVisibleData();
        }

        private void lblProfileImage_Click(object sender, EventArgs e)
        {

        }
        //mouseDownEvent
        private void lblVisible_MouseDown(object sender, MouseEventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
        }

        private void lblProfileImage_MouseDown(object sender, MouseEventArgs e)
        {
            lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseDown, 1);
        }

        //mouseEnterEvent
        private void lblVisible_MouseEnter(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);

            Tooltip.Show(1, Strings.Set("Hide/Show content.", "", ""));
        }

        private void lblProfileImage_MouseEnter(object sender, EventArgs e)
        {
            lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, ButtonColor.MouseEnter, 1);

            Tooltip.Show(1, Strings.Set("Choose image.", "", ""));
        }

        //mouseLeaveEvent
        private void lblVisible_MouseLeave(object sender, EventArgs e)
        {
            lblVisible.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);

            Tooltip.Show();
        }

        private void lblProfileImage_MouseLeave(object sender, EventArgs e)
        {
            lblProfileImage.BackColor = ButtonColor.Set(ButtonColor.Gainsboro, 0, 1);

            Tooltip.Show();
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            frmIndex frmIndex = Library.clsFormsAndUserControls.FrmIndex;

            int i = 0;

            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row[1]) == frmIndex.OpenProjectId)
                {
                    i++;
                }
            }

            if (i == 0)
            {
                table.Rows.Add(new object[] { null, frmIndex.OpenProjectId, true });
            }

            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row[1]) == frmIndex.OpenProjectId)
                {
                    id = Convert.ToInt32(row[0]);
                    visibleContent = Convert.ToBoolean(row[2]);
                }
            }

            panProfileImage.Visible = visibleContent;
        }

        private void Choose()
        {

        }

        private void SaveVisibleData()
        {
            DataRow row = table.Rows.Find(id);

            if (row != null)
            {
                row["Visible"] = visibleContent;
            }
        }

        private void HideShowContent(int action = 0)
        {
            if (visibleContent == true)
            {
                lblVisible.Text = Strings.Set("Show", "", "");
                visibleContent = false;
            }
            else
            {
                lblVisible.Text = Strings.Set("Hide", "", "");
                visibleContent = true;
            }

            panProfileImage.Visible = visibleContent;
        }

        private void SetControlsText()
        {
            lblHeading.Text = Strings.Set("Profile Image", "Профилна слика", "Profilna slika");

            if (visibleContent == true)
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