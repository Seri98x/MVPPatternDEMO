using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MVPPatternDEMO.CustomControls;
using MVPPatternDEMO.Interfaces;

namespace MVPPatternDEMO
{
    public partial class MainView : Form , IMainView
    {
        private string _firstName;
        private string _lastName;
        private string _middleName;
        private string _position;
        private string _age;
        private string _salary;
        private string _message;
        private string _employeeId;
        private bool _isEdit;

        public MainView()
        {
            InitializeComponent();
            SetViewEvents();
        }

       
        private void SetViewEvents()
        {
            dgvEmployeeList.SelectionChanged += (s, e) =>
            {
                EditEvent?.Invoke(this, EventArgs.Empty);
            };

            dgvEmployeeList.CellEndEdit += (s, e) =>
            {
               AddNewEvent?.Invoke(this, EventArgs.Empty);
            };

           
            foreach(Control pTextBox in this.tableLayoutPanel1.Controls)
            {
                if (pTextBox is PlaceholderTextBox)
                {
                    pTextBox.KeyPress += (s, e) =>
                    {
                        TextBoxKeyPressEvent?.Invoke(this, e);
                    };
                }
            }
        }

        public string EmployeeId 
        {
            get { return _employeeId; } 
            set { _employeeId = value; } 
        }


        public string FirstName 
        {
            get { return ptbFirstName.Text; }
            set { ptbFirstName.Text = value; } 
        }
        public string LastName 
        { 
            get  { return ptbLastName.Text; } 
            set  { ptbLastName.Text = value; } 
        }
        public string MiddleName 
        { 
            get { return ptbMiddleName.Text; }
            set { ptbMiddleName.Text = value;  } 
        }
        public string Position 
        { 
            get { return ptbPosition.Text; }
            set { ptbPosition.Text = value; } 
        }
        public string Age 
        {
            get { return ptbAge.Text; }
            set { ptbAge.Text = value; } 
        }
        public string Salary 
        {
            get 
            {
                return ptbSalary.Text;
            }
            set 
            {
               ptbSalary.Text = value;
            } 
        }
        public string Message 
        {
            get { return _message; }
            set { _message = value; } 
        }

        public bool IsEdit 
        { 
            get { return _isEdit; }
            set { _isEdit = value; } 
        }

        public event EventHandler AddNewEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler EditEvent;
        public event EventHandler<KeyPressEventArgs> TextBoxKeyPressEvent;

        public void SetEmployeeListBindingSource(BindingSource employeeList)
        {
            dgvEmployeeList.DataSource = employeeList;
            dgvCopy.DataSource = employeeList;
        }
    }
}
