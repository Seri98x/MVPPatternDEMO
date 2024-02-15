using MVPPatternDEMO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPatternDEMO.Interfaces
{
    public interface IEmployeeRepository
    {
        Task  AddEmployeeAsync(EmployeeModel employeeModel);
        void EditEmployeeAsync(EmployeeModel employeeModel);
        void DeleteEmployee(int id);
        IEnumerable<EmployeeModel> GetAll();
        IEnumerable<EmployeeModel> GetByValue();
    }
}
