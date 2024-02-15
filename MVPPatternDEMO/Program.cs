using MVPPatternDEMO.Interfaces;
using MVPPatternDEMO.Repositories;
using MVPPatternDEMO.ViewPresenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPatternDEMO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);



            IMainView mainView = new MainView();

            IEmployeeRepository employeeRepository = new EmployeeRepository();


            new MainViewPresenter(mainView, employeeRepository);


            Application.Run((Form)mainView);
        }
    }
}
