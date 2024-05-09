using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shahid
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SignUpForm());
            //Application.Run(new LoginForm());
            //Application.Run(new UserMainMenu());
            //Application.Run(new WelcomeForm());
            Application.Run(new AdminForm());
            //Application.Run(new CrystalReportForm());
            //Application.Run(new CrystalReportForm2());
        }
    }
}
