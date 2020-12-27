using LoginUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLCH_UI
{
    static class Program
    {
        static ApplicationContext MainContext = new ApplicationContext();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (DAO.ConnectSQL.Instance.TestConnString())
            {
                MainContext.MainForm = new LoginForm();
                Application.Run(MainContext);
            }
            else
            {
                MessageBox.Show("Can't connect to database. Please contact Provider.");
            }
        }

        public static void SetMainForm(Form MainForm)
        {
            MainContext.MainForm = MainForm;
        }

        public static void ShowMainForm()
        {
            MainContext.MainForm.Show();
        }
    }

}
    
