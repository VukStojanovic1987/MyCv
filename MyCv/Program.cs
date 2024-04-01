using System;
using System.Threading;
using System.Windows.Forms;

namespace MyCv
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static Mutex mutex = null;

        [STAThread]
        static void Main()
        {
            const string appName = "MyCv";
            bool createNew;

            mutex = new Mutex(true, appName, out createNew);

            if (!createNew)
            {
                MyMessage.clsDialog Dialog = new MyMessage.clsDialog();
                Library.clsString Strings = new Library.clsString();

                Dialog.Show("MyCv", "", "i", Strings.Set("The application is already running.", "", ""), Dialog.OkOnly);
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmIndex());
        }
    }
}