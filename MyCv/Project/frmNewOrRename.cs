using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MyCv.Project
{
    public partial class frmNewOrRename : Form
    {
        //class
        Library.clsString Strings = new Library.clsString();
        Library.clsButtonColor ButtonColor = new Library.clsButtonColor();

        //variable
        private frmIndex frmIndex = Library.clsFormsAndUserControls.FrmIndex;
        private DataTable table = Library.clsData.Projects;
        private int id = 0;
        private string name = "";

        //property
        public int FormType { get; set; } = 0;

        //constructor
        public frmNewOrRename()
        {
            InitializeComponent();
        }
        
        //formEvent
        private void frmNewOrRename_Load(object sender, EventArgs e)
        {
            SetControlsText();

            LoadData();
        }

        private void frmNewOrRename_Shown(object sender, EventArgs e)
        {
            txtName.Focus();
            txtName.SelectAll();
        }

        //mouseClickEvent
        private void lblOk_Click(object sender, EventArgs e)
        {
            if(Validation() == true)
            {
                SaveData();
                Close();
            }
        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        //mouseDownEvent
        private void lblOk_MouseDown(object sender, MouseEventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
        }

        private void lblCancel_MouseDown(object sender, MouseEventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseDown);
        }

        //mouseEnterEvent
        private void lblOk_MouseEnter(object sender, EventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        private void lblCancel_MouseEnter(object sender, EventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);
        }

        //mouseLeaveEvent
        private void lblOk_MouseLeave(object sender, EventArgs e)
        {
            lblOk.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        private void lblCancel_MouseLeave(object sender, EventArgs e)
        {
            lblCancel.BackColor = ButtonColor.Set(ButtonColor.Gray);
        }

        //textChangedEvent
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Validation();
        }

        #region methodsAndFunctions
        //methods
        private void LoadData()
        {
            if(FormType == 0)
            {
                if (table.Rows.Count == 0)
                {
                    name = Strings.Set("newProject", "новиПројекат", "noviProjekat");
                }
                else
                {
                    int i = table.Rows.Count + 1;
                    name = Strings.Set("newProject", "новиПројекат", "noviProjekat") + i.ToString();
                }
            }
            else
            {
                id = Convert.ToInt32(frmIndex.DgvView.CurrentRow.Cells[0].Value);

                DataRow row = table.Rows.Find(id);

                if (row != null)
                {
                    name = row["Name"].ToString();
                }
            }

            txtName.Text = name;
        }

        private void SaveData()
        {
            name = txtName.Text;

            if(FormType == 0)
            {
                table.Rows.Add(new object[] { null, name });

                Library.clsSelectRow SelectRow = new Library.clsSelectRow();
                SelectRow.LastAdded(frmIndex.DgvView, table);
            }
            else
            {
                DataRow row = table.Rows.Find(id);

                if (row != null)
                {
                    row["Name"] = name;
                }

                if(frmIndex.OpenProjectId == id)
                {
                    frmIndex.Text = "[" + name + "] - MyCv";
                }
            }
        }

        private void SetControlsText()
        {
            if(FormType == 0)
            {
                lblHeading.Text = Strings.Set("PROJECT\\NEW", "ПРОЈЕКАТ\\НОВИ", "PROJEKAT\\NOVI");
            }
            else
            {
                lblHeading.Text = Strings.Set("PROJECT\\RENAME", "ПРОЈЕКАТ\\ПРОМЕНА НАЗИВА", "PROJEKAT\\PROMENA NAZIVA");
            }
            
            lblOk.Text = Strings.Set("OK", "ОК", "OK");
            lblCancel.Text = Strings.Set("Cancel", "Откажи", "Otkaži");
            lblName.Text = Strings.Set("Name:", "Назив:", "Naziv:");
        }

        //functions
        private bool Validation()
        {
            lblMessage.Text = "";

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                lblMessage.Text = Strings.Set("Please name the new project.", "", "");
                return false;
            }

            if (txtName.Text.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                lblMessage.Text = Strings.Set(@"List of characters that cannot be used when naming a project: / \ : * ? "" < > |", "", "");
                return false;
            }

            if(FormType == 0)
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[1].ToString().ToLower() == txtName.Text.ToLower())
                    {
                        lblMessage.Text = Strings.Set("The given name already exists.", "", "");
                        return false;
                    }
                }
            }
            else
            {
                foreach (DataRow row in table.Rows)
                {
                    if (row[1].ToString().ToLower() != name.ToLower())
                    {
                        if (row[1].ToString().ToLower() == txtName.Text.ToLower())
                        {
                            lblMessage.Text = Strings.Set("The given name already exists.", "", "");
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (ModifierKeys == Keys.None && keyData == Keys.Enter)
            {
                if(Validate() == true)
                {
                    SaveData();
                    Close();
                }
                return true;
            }
            else if (ModifierKeys == Keys.None && keyData == Keys.Escape)
            {
                Close();
                return true;
            }
            return base.ProcessDialogKey(keyData);
        }
        #endregion
    }
}