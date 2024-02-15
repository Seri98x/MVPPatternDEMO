using MVPPatternDEMO.Interfaces;
using MVPPatternDEMO.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPatternDEMO.ViewPresenters
{
    public class MainViewPresenter
    {
        private IMainView mainView;
        private IEmployeeRepository employeeRepository;
        private BindingSource employeeBindingSource;
        private IEnumerable<EmployeeModel> employeeList;

        public MainViewPresenter(IMainView mainView, IEmployeeRepository employeeRepository)
        {

            this.employeeBindingSource = new BindingSource();

            
            this.mainView = mainView;

            this.employeeRepository = employeeRepository;

            this.mainView.SaveEvent += SaveEmployeeNewDetails;
            this.mainView.AddNewEvent += AddNewEmployee;
            this.mainView.EditEvent += LoadSelectedEmployeeToEdit;
            this.mainView.TextBoxKeyPressEvent += BlockCertainKeys;
            this.mainView.SetEmployeeListBindingSource(this.employeeBindingSource);

            LoadEmployeeList();

            this.mainView.Show();
        }

        private void BlockCertainKeys(object sender, KeyPressEventArgs e)
        {
            e.Handled = IsBlockedKey(e.KeyChar);
        }

        public Boolean IsBlockedKey(char ch)
        {
            Boolean isHandled =true;
            if(!char.IsDigit(ch) && (ch != (int)BlockedKeys.GSmallKey) && (ch != (int)BlockedKeys.GBigKey))
            { 
                isHandled = false;
                MessageBox.Show("Not 'G' key");
            }
            return isHandled;
        }

        enum BlockedKeys
        {
            EnterKey = 13,
            GSmallKey = 103,
            GBigKey = 71,
        }


        private void LoadEmployeeList()
        {
            employeeList = employeeRepository.GetAll();
            employeeBindingSource.DataSource = employeeList;
        }

        private void LoadSelectedEmployeeToEdit(object sender, EventArgs e)
        {
            var employee = (EmployeeModel)employeeBindingSource.Current;
            mainView.EmployeeId = employee.Id.ToString();
            mainView.FirstName = employee.FirstName;
            mainView.LastName = employee.LastName;
            mainView.MiddleName = employee.MiddleName;
            mainView.Age = employee.Age.ToString();
            mainView.Position = employee.Position;
            mainView.Salary = employee.Salary.ToString();   
        }


        private async void AddNewEmployee(object sender, EventArgs e)
        {
            var employee = (EmployeeModel)employeeBindingSource.Current;
            employee.Id = employeeBindingSource.Count;
            await employeeRepository.AddEmployeeAsync(employee);
            LoadEmployeeList();
        }

        private void SaveEmployeeNewDetails(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
