using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.WorkExperience
{
    public partial class ucView : UserControl
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        private Library.clsTooltip Tooltip = new Library.clsTooltip();
        private Library.clsCardNumber CardNumber = new Library.clsCardNumber();

        //variable
        private DataTable table = Library.clsData.WorkExperience;
        private frmIndex frmIndex = Library.clsFormsAndUserControls.FrmIndex;

        //property
        public Panel PanContent { get { return panContent; } }

        //constructor
        public ucView()
        {
            InitializeComponent();
        }

        //userControlEvent
        private void ucEducation_Load(object sender, EventArgs e)
        {
            Library.clsFormsAndUserControls.UcWorkExperienceView = this;

            SetControlsText();

            LoadData();

            CardNumber.Set(panContent, Strings.Set("Work Experience N°", "Радно искуство БР", "Radno iskustvo BR"));
        }

        //mouseClickEvent
        private void lblAdd_Click(object sender, EventArgs e)
        {
            Add();

            CardNumber.Set(panContent, Strings.Set("Work Experience N°", "Радно искуство БР", "Radno iskustvo BR"));
        }

        //mouseDownEvent
        private void lblAdd_MouseDown(object sender, MouseEventArgs e)
        {
            lblAdd.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        //mouseEnterEvent
        private void lblAdd_MouseEnter(object sender, EventArgs e)
        {
            lblAdd.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Add Work Experience", "", ""));
        }

        //mouseLeaveEvent
        private void lblAdd_MouseLeave(object sender, EventArgs e)
        {
            lblAdd.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            foreach(DataRow row in table.Rows)
            {
                if(Convert.ToInt32(row[1]) == frmIndex.OpenProjectId)
                {
                    ucEdit userControl = new ucEdit();
                    userControl.ID = Convert.ToInt32(row[0]);
                    userControl.weName = Convert.ToString(row[2]);
                    userControl.Position = Convert.ToString(row[3]);
                    userControl.Attended = Convert.ToString(row[4]);
                    userControl.Description = Convert.ToString(row[5]);
                    userControl.VisibleContent = Convert.ToBoolean(row[6]);
                    userControl.Dock = DockStyle.Top;
                    panContent.Controls.Add(userControl);
                }
            }
        }

        private void Add()
        {
            table.Rows.Add(new object[] { null, frmIndex.OpenProjectId, "", "", "", "", true });

            DataRow row = table.Rows[table.Rows.Count - 1];

            ucEdit userControl = new ucEdit();
            userControl.ID = Convert.ToInt32(row[0]);
            userControl.weName = Convert.ToString(row[2]);
            userControl.Position = Convert.ToString(row[3]);
            userControl.Attended = Convert.ToString(row[4]);
            userControl.Description = Convert.ToString(row[5]);
            userControl.VisibleContent = Convert.ToBoolean(row[6]);
            userControl.Dock = DockStyle.Top;
            panContent.Controls.Add(userControl);
        }

        private void SetControlsText()
        {
            lblHeading.Text = Strings.Set("Work Experience", "Радно искуство", "Radno iskustvo");
            lblAdd.Text = Strings.Set("Add", "Додај", "Dodaj");
        }
        #endregion
    }
}