using System;
using System.Data;
using System.Windows.Forms;

namespace MyCv
{
    public partial class frmIndex : Form
    {
        //class
        private Library.clsString Strings = new Library.clsString();
        private Library.clsButtonColor ButtonColor = new Library.clsButtonColor();
        private Library.clsTooltip Tooltip = new Library.clsTooltip();

        //variable
        private string validationMessage = "";

        //property
        public DataGridView DgvView { get { return dgvView; } }
        public Label LblProject { get { return lblProject; } }
        public Label LblMessage { get { return lblMessage; } }
        public int OpenProjectId { get; set; } = 0;

        //constructor
        public frmIndex()
        {
            InitializeComponent();
        }

        //formEvent
        private void frmIndex_Load(object sender, EventArgs e)
        {
            Library.clsFormsAndUserControls.FrmIndex = this;

            SetControlsText();

            Library.clsData.Load();

            dgvView.DataSource = Library.clsData.Projects;
            
            SetDgv();
        }

        private void frmIndex_Shown(object sender, EventArgs e)
        {
            dgvView.Focus();
        }

        private void frmIndex_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        //mouseClickEvent
        private void lblSave_Click(object sender, EventArgs e)
        {

        }

        private void lblPrint_Click(object sender, EventArgs e)
        {

        }

        private void lblAuthor_Click(object sender, EventArgs e)
        {

        }

        private void lblLanguage_Click(object sender, EventArgs e)
        {

        }

        private void lblNew_Click(object sender, EventArgs e)
        {
            New();
        }

        private void lblOpen_Click(object sender, EventArgs e)
        {
            if (Validation(1) == true)
            {
                Tooltip.Show();
            }
            else
            {
                Tooltip.Show(1, validationMessage);
                return;
            }

            Open();
        }

        private void lblRename_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                Tooltip.Show();
            }
            else
            {
                Tooltip.Show(1, validationMessage);
                return;
            }

            Rename();
        }

        private void lblRemove_Click(object sender, EventArgs e)
        {
            if (Validation() == true)
            {
                Tooltip.Show();
            }
            else
            {
                Tooltip.Show(1, validationMessage);
                return;
            }

            Remove();
        }

        //mouseDoubleClickEvent
        private void dgvView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Validation(1) == true)
            {
                Open();
            }
        }

        //mouseDownEvent
        private void lblSave_MouseDown(object sender, MouseEventArgs e)
        {
            lblSave.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblPrint_MouseDown(object sender, MouseEventArgs e)
        {
            lblPrint.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblAuthor_MouseDown(object sender, MouseEventArgs e)
        {
            lblAuthor.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblLanguage_MouseDown(object sender, MouseEventArgs e)
        {
            lblLanguage.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblNew_MouseDown(object sender, MouseEventArgs e)
        {
            lblNew.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblOpen_MouseDown(object sender, MouseEventArgs e)
        {
            lblOpen.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblRename_MouseDown(object sender, MouseEventArgs e)
        {
            lblRename.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        private void lblRemove_MouseDown(object sender, MouseEventArgs e)
        {
            lblRemove.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseDown);
        }

        //mouseEnterEvent
        private void lblSave_MouseEnter(object sender, EventArgs e)
        {
            lblSave.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Save your progress.", "", ""));
        }

        private void lblPrint_MouseEnter(object sender, EventArgs e)
        {
            lblPrint.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Print your project.", "", ""));
        }

        private void lblAuthor_MouseEnter(object sender, EventArgs e)
        {
            lblAuthor.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("About author.", "", ""));
        }

        private void lblLanguage_MouseEnter(object sender, EventArgs e)
        {
            lblLanguage.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Select your language.", "", ""));
        }

        private void lblNew_MouseEnter(object sender, EventArgs e)
        {
            lblNew.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            Tooltip.Show(1, Strings.Set("Create a new project to continue.", "", ""));
        }

        private void lblOpen_MouseEnter(object sender, EventArgs e)
        {
            lblOpen.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            if (Validation(1) == true)
            {
                Tooltip.Show(1, Strings.Set("Open your project.", "", ""));
            }
            else
            {
                Tooltip.Show(1, validationMessage);
            }
        }

        private void lblRename_MouseEnter(object sender, EventArgs e)
        {
            lblRename.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            if (Validation() == true)
            {
                Tooltip.Show(1, Strings.Set("Rename your project.", "", ""));
            }
            else
            {
                Tooltip.Show(1, validationMessage);
            }   
        }

        private void lblRemove_MouseEnter(object sender, EventArgs e)
        {
            lblRemove.BackColor = ButtonColor.Set(ButtonColor.DimGray, ButtonColor.MouseEnter);

            if (Validation() == true)
            {
                Tooltip.Show(1, Strings.Set("Remove a project.", "", ""));
            }
            else
            {
                Tooltip.Show(1, validationMessage);
            }
        }

        //mouseLeaveEvent
        private void lblSave_MouseLeave(object sender, EventArgs e)
        {
            lblSave.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblPrint_MouseLeave(object sender, EventArgs e)
        {
            lblPrint.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblAuthor_MouseLeave(object sender, EventArgs e)
        {
            lblAuthor.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblLanguage_MouseLeave(object sender, EventArgs e)
        {
            lblLanguage.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblNew_MouseLeave(object sender, EventArgs e)
        {
            lblNew.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblOpen_MouseLeave(object sender, EventArgs e)
        {
            lblOpen.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblRename_MouseLeave(object sender, EventArgs e)
        {
            lblRename.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        private void lblRemove_MouseLeave(object sender, EventArgs e)
        {
            lblRemove.BackColor = ButtonColor.Set(ButtonColor.DimGray);

            Tooltip.Show();
        }

        //keyDownEvent
        private void dgvView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Validation(1) == true)
                {
                    Open();
                    e.Handled = true;
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (Validation() == true)
                {
                    Remove();
                }
            }
        }

        #region methodsAndFunctions
        //methods
        private void New()
        {
            using(Project.frmNewOrRename form = new Project.frmNewOrRename())
            {
                form.FormType = 0;
                form.ShowDialog();
            }
        }

        private void Open()
        {
            OpenProjectId = Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value);

            Library.CloseContainerForm CloseContainerForm = new Library.CloseContainerForm(panContent);

            lblProject.Dock = DockStyle.Right;
            lblMessage.Dock = DockStyle.Left;

            Text = "[" + dgvView.CurrentRow.Cells[1].Value.ToString() + "] - MyCv";

            Project.frmView form = new Project.frmView();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            panContent.Controls.Add(form);
            form.Show();
        }

        private void Rename()
        {
            using (Project.frmNewOrRename form = new Project.frmNewOrRename())
            {
                form.FormType = 1;
                form.ShowDialog();
            }
        }

        private void Remove()
        {
            MyMessage.clsDialog Dialog = new MyMessage.clsDialog();

            int id = Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value);
            string name = Convert.ToString(dgvView.CurrentRow.Cells[1].Value);

            if (Dialog.Show(Strings.Set("Question Message - MyCv", "", ""),
                            Strings.Set("PROJECT\\REMOVE", "", ""),
                            "?",
                            Strings.Set("Do you wish to remove selected project '" + name + "'?", "", ""), Dialog.YesNo) == Dialog.No){ return; }

            if (OpenProjectId == id)
            {
                Library.CloseContainerForm CloseContainerForm = new Library.CloseContainerForm(panContent);

                OpenProjectId = 0;
                lblProject.Dock = DockStyle.Left;
                lblMessage.Dock = DockStyle.Right;
                Text = "MyCv";
            }
            
            DataRow row = Library.clsData.Projects.Rows.Find(id);

            if (row != null)
            {
                row.Delete();

                if (dgvView.CurrentRow != null)
                {
                    dgvView.CurrentRow.Selected = true;
                }
            }
        }

        private void SetControlsText()
        {
            lblSave.Text = Strings.Set("Save", "Снимите", "Snimite");
            lblPrint.Text = Strings.Set("Print", "Штампа", "Štampa");
            lblAuthor.Text = Strings.Set("Author", "Аутор", "Autor");
            lblLanguage.Text = Strings.Set("Eng", "Срб", "Srb");
            lblProject.Text = Strings.Set("Project:", "Пројекат:", "Projekat:");
            lblNew.Text = Strings.Set("New", "Нови", "Novi");
            lblOpen.Text = Strings.Set("Open", "Отворите", "Otvorite");
            lblRename.Text = Strings.Set("Rename", "Промена\nназива", "Promena\nnaziva");
            lblRemove.Text = Strings.Set("Remove", "Уклоните", "Uklonite");
        }

        private void SetDgv()
        {
            if (dgvView.ColumnCount == 2)
            {
                dgvView.Columns[0].HeaderText = Strings.Set("ID", "ИД", "ID");
                dgvView.Columns[1].HeaderText = Strings.Set("Name", "Назив", "Naziv");

                dgvView.Columns[0].Visible = false;

                dgvView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        //functions
        private bool Validation(int set = 0)
        {
            validationMessage = "";

            if (dgvView.RowCount == 0)
            {
                validationMessage = Strings.Set("No project was selected.", "", "");
                return false;
            }

            if (dgvView.CurrentRow == null)
            {
                validationMessage = Strings.Set("There are no projects.", "", "");
                return false;
            }

            if(set != 0)
            {
                if (OpenProjectId == Convert.ToInt32(dgvView.CurrentRow.Cells[0].Value))
                {
                    validationMessage = Strings.Set("Selected project is already open.", "", "");
                    return false;
                }
            }
            return true;
        }
        #endregion
    }
}