namespace MyCv.Library
{
    class clsTooltip
    {
        public void Show(int i = 0, string text = "")
        {
            clsButtonColor ButtonColor = new clsButtonColor();

            frmIndex form = clsFormsAndUserControls.FrmIndex;

            form.LblMessage.Text = text;

            if (i == 1)
            {
                form.LblMessage.BackColor = ButtonColor.Set(ButtonColor.Gray, ButtonColor.MouseEnter);

            }
            else
            {
                form.LblMessage.BackColor = ButtonColor.Set(ButtonColor.Gray);
            }
        }
    }
}