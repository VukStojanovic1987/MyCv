using System.Windows.Forms;

namespace MyCv.Library
{
    class CloseContainerForm
    {
        public CloseContainerForm(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Form)
                {
                    Form form = (Form)control;
                    form.Close();
                }
            }
        }
    }
}