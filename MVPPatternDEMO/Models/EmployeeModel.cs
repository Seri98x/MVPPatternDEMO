using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPatternDEMO.Models
{
   public class EmployeeModel
    {


        //fully qualify the properties with the backing fields
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _position;
        private string _office;
        private int _id;
        private int _age;
        private decimal _salary;

        [DisplayName("Employee ID")]
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        [DisplayName("Employee First Name")]
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        [DisplayName("Employee Middle Name")]
        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }

        [DisplayName("Employee Last Name")]
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        [DisplayName("Employee Position")]
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        [DisplayName("Employee Office")]
        public string Office
        {
            get { return _office; }
            set { _office = value; }
        }

        [DisplayName("Employee Age")]
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        [DisplayName("Employee Salary")]
        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}
