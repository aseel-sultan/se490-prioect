using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using my_1stProject.forms;
namespace my_1stProject
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
           Application.Run(new loginpage());

            //Application.Run(new mainPage());

          //Application.Run(new usersPage());
       // Application.Run(new updatePage());
        }
    }
}
