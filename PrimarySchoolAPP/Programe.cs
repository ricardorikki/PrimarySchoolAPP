using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PrimarySchoolAPP
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
            const string appName = "MyAppName";
            bool createdNew;

            mutex = new Mutex(true, appName, out createdNew);

            if (!createdNew)
            {
                MessageBox.Show("app is already running! Exiting the application ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Question);
 //app is already running! Exiting the application  
                return;
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
      
    }
}
