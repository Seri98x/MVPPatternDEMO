using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVPPatternDEMO.Interfaces
{
   
    public interface IMainView
    {
        string EmployeeId { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Position { get; set; }
        string Age { get; set; }
        string Salary { get; set; }
        string Message { get; set; }

        bool IsEdit { get; set; }

        event EventHandler AddNewEvent;
        event EventHandler DeleteEvent;
        event EventHandler SaveEvent;
        event EventHandler EditEvent;
        event EventHandler<KeyPressEventArgs> TextBoxKeyPressEvent;

        void SetEmployeeListBindingSource(BindingSource employeeList);
        void Show();
    }
}
