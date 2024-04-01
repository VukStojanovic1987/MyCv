using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.PersonalInfo
{
    public partial class ucView : UserControl
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();

        //variable
        private DataTable table = Library.clsData.PersonalInfo;

        //constructor
        public ucView()
        {
            InitializeComponent();
        }

        //userControlEvent
        private void ucEducation_Load(object sender, EventArgs e)
        {
            SetControlsText();

            LoadData();
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
                table.Rows.Add(new object[] { null, frmIndex.OpenProjectId, "", "", "", "", "", "", "", true });
            }

            foreach (DataRow row in table.Rows)
            {
                if (Convert.ToInt32(row[1]) == frmIndex.OpenProjectId)
                {
                    ucEdit userControl = new ucEdit();
                    userControl.ID = Convert.ToInt32(row[0]);
                    userControl.piName = Convert.ToString(row[2]);
                    userControl.LastName = Convert.ToString(row[3]);
                    userControl.DateOfBirth = Convert.ToString(row[4]);
                    userControl.PhoneNumber = Convert.ToString(row[5]);
                    userControl.Email = Convert.ToString(row[6]);
                    userControl.Title = Convert.ToString(row[7]);
                    userControl.BrieflyAboutYourself = Convert.ToString(row[8]);
                    userControl.VisibleContent = Convert.ToBoolean(row[9]);
                    userControl.Dock = DockStyle.Top;
                    panContent.Controls.Add(userControl);
                }
            }
        }

        private void SetControlsText()
        {
            lblHeading.Text = Strings.Set("Personal Info", "Личне информације", "Lične informacije");;
        }
        #endregion
    }
}