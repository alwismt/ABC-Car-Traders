using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_traders
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
            
            //Application.Run(new Forms.Login_Form());
            //Application.Run(new Forms.AdminDashboard());
            
            
            
            ///Application.Run(new Forms.UserDashboard());
            
            Application.Run(new Forms.SplashScreen());


            Forms.SplashScreen sp = new Forms.SplashScreen();
            if (sp.ShowDialog() == DialogResult.OK) 
            {
                Application.Run(new Forms.Login_Form());
            }
            
        }
    }
}
