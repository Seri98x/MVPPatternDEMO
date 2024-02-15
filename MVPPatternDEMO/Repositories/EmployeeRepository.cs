using GMSPH_ADMIN_PORTAL;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4.Data;
using Google.Apis.Sheets.v4;
using MVPPatternDEMO.Interfaces;
using MVPPatternDEMO.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Google.Apis.Sheets.v4.SheetsService;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MVPPatternDEMO.Repositories
{

    public class EmployeeRepository : IEmployeeRepository
    {
        static readonly string[] Scopes = { SheetsService.Scope.Spreadsheets };
        private static SheetsService service;

        public async Task AddEmployeeAsync(EmployeeModel employeeModel)
        {
            GoogleCredential credential;
            using (var stream = new FileStream("branch-412905-838dc6acb0e0.json",
                FileMode.Open,
                FileAccess.Read))
            {
                credential = GoogleCredential.FromStream(stream)
                    .CreateScoped(Scopes);
            }
            service = new SheetsService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "TestSheet",
            });
            var range = $"{"FirstSheet"}";
            var valueRange = new ValueRange();
            var oblist = new List<object>()
            {
                employeeModel.Id,
                employeeModel.FirstName,
                employeeModel.MiddleName,
                employeeModel.LastName,
                employeeModel.Position,
                employeeModel.Office,
                employeeModel.Age,
                employeeModel.Salary
            };
            valueRange.Values = new List<IList<object>> { oblist };
            var appendRequest = service.Spreadsheets.Values.Append(valueRange, "1hlg-WLvL_Z2XSVaA6buNA-GzUiODKh0ckskbK5wG7qE", range);
            appendRequest.ValueInputOption = SpreadsheetsResource.ValuesResource.AppendRequest.ValueInputOptionEnum.USERENTERED;
            var appendReponse = await appendRequest.ExecuteAsync();
        }

        public void DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public  void EditEmployeeAsync(EmployeeModel employeeModel)
        {

           
        }

        public IEnumerable<EmployeeModel> GetAll()
        {
            var gsh = new GSI2("branch-412905-838dc6acb0e0.json",
        "1hlg-WLvL_Z2XSVaA6buNA-GzUiODKh0ckskbK5wG7qE", "TestSheets");
            var gsp = new GoogleSheetParameters()
            {
                RangeColumnStart = 1,
                RangeRowStart = 1,
                RangeColumnEnd = 8,
                RangeRowEnd = 10000,
                FirstRowIsHeaders = true,
                SheetName = "FirstSheet",

            };

            var rowValues = gsh.GetDataFromSheet(gsp);
            var dt = new DataTable();
            if (rowValues.Count > 0)
            {

                ExpandoObject first = rowValues.First();
                var first_d = (IDictionary<string, object>)first;
                foreach (var key in first_d.Keys)
                {
                    var val = rowValues.Select(o => ((IDictionary<string, object>)o)[key]).FirstOrDefault(v => v != null);
                    dt.Columns.Add(key, val?.GetType() ?? typeof(object));
                }
                foreach (var obj in rowValues)
                {
                    dt.Rows.Add(dt.Columns.Cast<DataColumn>().Select(c => ((IDictionary<string, object>)obj)[c.ColumnName]).ToArray());
                }
            }
            List<EmployeeModel> employeeList = new List<EmployeeModel>();
            foreach (DataRow row in dt.Rows)
            {
                var employee = new EmployeeModel();
                employee.Id = Convert.ToInt32(row.Field<string>("Employee ID"));
                employee.FirstName = row.Field<string>("Employee First Name");
                employee.LastName = row.Field<string>("Employee Last Name");
                employee.MiddleName = row.Field<string>("Employee Middle Name"); 
                employee.Position = row.Field<string>("Employee Position");
                employee.Office = row.Field<string>("Employee Office");
                employee.Age = Convert.ToInt32(row.Field<string>("Employee Age"));
                employee.Salary = Convert.ToDecimal(row.Field<string>("Employee Salary"));

                employeeList.Add(employee);
            }
            return employeeList;
        }

        public IEnumerable<EmployeeModel> GetByValue()
        {
            throw new NotImplementedException();
        }
    }
}
