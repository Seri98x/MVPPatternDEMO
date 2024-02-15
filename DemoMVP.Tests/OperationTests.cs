using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using MVPPatternDEMO.Interfaces;
using MVPPatternDEMO.Models;
using MVPPatternDEMO.Repositories;
using System.Net.Http.Headers;
using System.Collections;
using MVPPatternDEMO.ViewPresenters;

namespace DemoMVP.Tests
{
  
    namespace DemoMVP.Tests
    {
        public class EmployeeRepositoryTests
        {
            private readonly IEmployeeRepository _employeeRepository;
            private readonly MainViewPresenter _mainViewPresenter;
            private readonly IMainView _mainView;
            public EmployeeRepositoryTests()
            {
                _employeeRepository = new MockEmployeeRepository();
                _mainView = new MockMainView();

                _mainViewPresenter = new MainViewPresenter(_mainView,_employeeRepository);
            }

            //[Fact]
            //public void GetAll_ReturnsCorrectEmployeeList()
            //{
            //    // Act
            //    IEnumerable<EmployeeModel> result = _employeeRepository.GetAll();
            //    EmployeeModelEqualityComparer comparer = new EmployeeModelEqualityComparer();
            //    // Assert
            //    var employee = new EmployeeModel()
            //    {
            //        Id = 1,
            //        Age = 20,
            //        FirstName = "Jose Mari",
            //        MiddleName = "Merana",
            //        LastName = "Ronquillo",
            //        Position = "Side",
            //        Office = "Makati",
            //        Salary = 10

            //    };
            //    var employeeList = new List<EmployeeModel>();
            //    employeeList.Add(employee);
            //    Assert.Equal(result,employeeList,comparer);
            //}

            [Fact]
            public void ReturnsTrueIfKeyIsLetterG ()
            {
               Assert.Equal(true,_mainViewPresenter.IsBlockedKey((char)71));
            }
        }

        class MockMainView : IMainView
        {
            public string EmployeeId { get ; set ; }
            public string FirstName { get ; set ; }
            public string LastName { get ; set ; }
            public string MiddleName { get ; set ; }
            public string Position { get ; set ; }
            public string Age { get ; set ; }
            public string Salary { get ; set ; }
            public string Message { get ; set ; }
            public bool IsEdit { get ; set ; }

            public event EventHandler AddNewEvent;
            public event EventHandler DeleteEvent;
            public event EventHandler SaveEvent;
            public event EventHandler EditEvent;
            public event EventHandler<System.Windows.Forms.KeyPressEventArgs> TextBoxKeyPressEvent;

            public void SetEmployeeListBindingSource(System.Windows.Forms.BindingSource employeeList)
            {
            }

            public void Show()
            {
            }
        }

        class EmployeeModelEqualityComparer : IEqualityComparer<EmployeeModel>
        {
            public bool Equals(EmployeeModel x, EmployeeModel y)
            {
                if (ReferenceEquals(x, y))
                    return true;

                if (x is null || y is null)
                    return false;

                return x.Id == y.Id &&
                       x.FirstName == y.FirstName &&
                       x.MiddleName == y.MiddleName &&
                       x.LastName == y.LastName &&
                       x.Position == y.Position &&
                       x.Office == y.Office &&
                       x.Age == y.Age &&
                       x.Salary == y.Salary;
            }

            public int GetHashCode(EmployeeModel obj)
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + obj.Id.GetHashCode();
                    hash = hash * 23 + (obj.FirstName?.GetHashCode() ?? 0);
                    hash = hash * 23 + (obj.MiddleName?.GetHashCode() ?? 0);
                    hash = hash * 23 + (obj.LastName?.GetHashCode() ?? 0);
                    hash = hash * 23 + (obj.Position?.GetHashCode() ?? 0);
                    hash = hash * 23 + (obj.Office?.GetHashCode() ?? 0);
                    hash = hash * 23 + obj.Age.GetHashCode();
                    hash = hash * 23 + obj.Salary.GetHashCode();
                    return hash;
                }
            }
        }

        class MockEmployeeRepository : IEmployeeRepository
        {
            public Task AddEmployeeAsync(EmployeeModel employeeModel)
            {
                throw new NotImplementedException();
            }

            public void DeleteEmployee(int id)
            {
                throw new NotImplementedException();
            }

            public void EditEmployeeAsync(EmployeeModel employeeModel)
            {
                throw new NotImplementedException();
            }

            public IEnumerable<EmployeeModel> GetAll()
            {
                var employee = new EmployeeModel()
                {
                    Id =1,
                    Age =20,
                    FirstName = "Jose Mari",
                    MiddleName = "Merana",
                    LastName = "Ronquillo",
                    Position = "Side",
                    Office = "Makati",
                    Salary = 10

                };
                var employeeList = new List<EmployeeModel>();
                employeeList.Add(employee);
                return employeeList;
            }

            public IEnumerable<EmployeeModel> GetByValue()
            {
                throw new NotImplementedException();
            }
        }
    }

}
