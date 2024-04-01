using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.Skills
{
    public partial class ucView : UserControl
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        private Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private DataTable table = Library.clsData.Skills;
        private frmIndex frmIndex = Library.clsFormsAndUserControls.FrmIndex;

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

        //mouseClickEvent
        private void lblAdd_Click(object sender, EventArgs e)
        {
            Add();
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

            Tooltip.Show(1, Strings.Set("Add Skill", "", ""));
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
                    userControl.SkillType = Convert.ToString(row[2]);
                    userControl.sName = Convert.ToString(row[3]);
                    userControl.VisibleContent = Convert.ToBoolean(row[4]);
                    userControl.Dock = DockStyle.Top;
                    panContent.Controls.Add(userControl);
                }
            }
        }

        private void Add()
        {
            table.Rows.Add(new object[] { null, frmIndex.OpenProjectId, "...", "", true });

            DataRow row = table.Rows[table.Rows.Count - 1];

            ucEdit userControl = new ucEdit();
            userControl.ID = Convert.ToInt32(row[0]);
            userControl.SkillType = Convert.ToString(row[2]);
            userControl.sName = Convert.ToString(row[3]);
            userControl.VisibleContent = Convert.ToBoolean(row[4]);
            userControl.Dock = DockStyle.Top;
            panContent.Controls.Add(userControl);
        }

        private void SetControlsText()
        {
            lblHeading.Text = Strings.Set("Skills", "Вештине", "Veštine");
            lblAdd.Text = Strings.Set("Add", "Додај", "Dodaj");
        }
        //functions
        #endregion
    }
}