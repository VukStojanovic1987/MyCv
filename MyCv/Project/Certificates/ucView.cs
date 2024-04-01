using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv.Project.Certificates
{
    public partial class ucView : UserControl
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        private Library.clsTooltip Tooltip = new Library.clsTooltip();
        private Library.clsCardNumber CardNumber = new Library.clsCardNumber();

        //variable
        private DataTable table = Library.clsData.Certificates;
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
            Library.clsFormsAndUserControls.UcCertificatesView = this;

            SetControlsText();

            LoadData();

            CardNumber.Set(panContent, Strings.Set("Certificates N°", "Сертификати БР", "Sertifikati BR"));
        }

        //mouseClickEvent
        private void lblAdd_Click(object sender, EventArgs e)
        {
            Add();

            CardNumber.Set(panContent, Strings.Set("Certificates N°", "Сертификати БР", "Sertifikati BR"));
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

            Tooltip.Show(1, Strings.Set("Add Certificate", "", ""));
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
                    userControl.cName = Convert.ToString(row[2]);
                    userControl.Attended = Convert.ToString(row[3]);
                    userControl.VisibleContent = Convert.ToBoolean(row[4]);
                    userControl.Dock = DockStyle.Top;
                    panContent.Controls.Add(userControl);
                }
            }
        }

        private void Add()
        {
            table.Rows.Add(new object[] { null, frmIndex.OpenProjectId, "", "", true });

            DataRow row = table.Rows[table.Rows.Count - 1];

            ucEdit userControl = new ucEdit();
            userControl.ID = Convert.ToInt32(row[0]);
            userControl.cName = Convert.ToString(row[2]);
            userControl.Attended = Convert.ToString(row[3]);
            userControl.VisibleContent = Convert.ToBoolean(row[4]);
            userControl.Dock = DockStyle.Top;
            panContent.Controls.Add(userControl);
        }

        private void SetControlsText()
        {
            lblHeading.Text = Strings.Set("Certificates", "Сертификати", "Sertifikati");
            lblAdd.Text = Strings.Set("Add", "Додај", "Dodaj");
        }
        #endregion
    }
}