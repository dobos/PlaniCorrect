using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Elte.PlaniCorrect.Lib;

namespace Elte.PlaniCorrect.UI
{
    static class Program
    {
        private static Forms.ControlForm control;
        private static Forms.ScreenForm screen;
        private static Layout layout;

        public static Forms.ControlForm Control
        {
            get { return control; }
        }

        public static Forms.ScreenForm Screen
        {
            get { return screen; }
        }

        public static Layout Layout
        {
            get { return layout; }
            set { layout = value; }
        }

        static Program()
        {
            layout = new Layout();
        }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            screen = new Forms.ScreenForm();
            control = new Forms.ControlForm();

            Application.Run(control);
        }
    }
}
