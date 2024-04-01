namespace MyCv.MyMessage
{
    class clsDialog
    {
        private clsOptions Options = new clsOptions();

        private int result = 0;

        public int OkOnly { get { return Options.OKOnly; } }
        public int YesNo { get { return Options.YesNo; } }
        public int YesNoCancel { get { return Options.YesNoCancel; } }

        public int Result { get { return result; } }
        public int OK { get { return Options.OK; } }
        public int Yes { get { return Options.Yes; } }
        public int No { get { return Options.No; } }
        public int Cancel { get { return Options.Cancel; } }

        public int Show(string caption, string heading, string iconText, string message, int messageType = 0)
        {
            using (frmYesNo form = new frmYesNo())
            {
                form.Caption = caption;
                form.Heading = heading;
                form.IconText = iconText;
                form.Message = message;
                form.MessageType = messageType;
                form.ShowDialog();
                result = form.Result;
            }
            return result;
        }
    }
}