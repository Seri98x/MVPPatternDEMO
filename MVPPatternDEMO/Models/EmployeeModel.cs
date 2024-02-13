using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVPPatternDEMO.Models
{
    internal class EmployeeModel
    {


        //fully qualify the properties with the backing fields
        private string _firstName;
        private string _middleName;
        private string _lastName;
        private string _position;
        private string _office;
        private int _age;
        private decimal _salary;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string MiddleName
        {
            get { return _middleName; }
            set { _middleName = value; }
        }


        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }


        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public string Office
        {
            get { return _office; }
            set { _office = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }
    }
}
