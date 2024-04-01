using System.Windows.Forms;

namespace MyCv.Library
{
    class clsCardNumber
    {
        public void Set(Panel panelContainer, string heading)
        {
            int i = 1;

            foreach (Control control in panelContainer.Controls)
            {
                if(control is Project.Certificates.ucEdit)
                {
                    Project.Certificates.ucEdit userControl = (Project.Certificates.ucEdit)control;
                    userControl.LblHeading.Text = heading + " " + i++.ToString();
                }
                else if (control is Project.WorkExperience.ucEdit)
                {
                    Project.WorkExperience.ucEdit userControl = (Project.WorkExperience.ucEdit)control;
                    userControl.LblHeading.Text = heading + " " + i++.ToString();
                }
                else if (control is Project.CoverLetters.ucEdit)
                {
                    Project.CoverLetters.ucEdit userControl = (Project.CoverLetters.ucEdit)control;
                    userControl.LblHeading.Text = heading + " " + i++.ToString();
                }
            }
        }
    }
}