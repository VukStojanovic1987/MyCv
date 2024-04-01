namespace MyCv.MyMessage
{
    class clsOptions
    {
        private const int oKOnly = 1;
        private const int yesNo = 2;
        private const int yesNoCancel = 3;

        private const int ok = 1;
        private const int yes = 2;
        private const int no = 3;
        private const int cancel = 4;

        public int OKOnly { get { return oKOnly; } }
        public int YesNo { get { return yesNo; } }
        public int YesNoCancel { get { return yesNoCancel; } }

        public int OK { get { return ok; } }
        public int Yes { get { return yes; } }
        public int No { get { return no; } }
        public int Cancel { get { return cancel; } }
    }
}