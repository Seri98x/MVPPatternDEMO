using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Sheets.v4;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSPH_ADMIN_PORTAL
{
    internal class GSI2
    {

        static string[] Scopes = { SheetsService.Scope.Spreadsheets };


        private readonly SheetsService _sheetsService;
        private readonly string _spreadsheetId;

        public GSI2(string credentialFileName, string spreadsheetId, string ApplicationName)
        {
            bool arewegood = true;
            while (arewegood)
            {
                try
                {
                    var credential = GoogleCredential.FromStream(new FileStream(credentialFileName, FileMode.Open)).CreateScoped(Scopes);

                    _sheetsService = new SheetsService(new BaseClientService.Initializer()
                    {
                        HttpClientInitializer = credential,
                        ApplicationName = ApplicationName,
                    });
                    arewegood = false;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine(spreadsheetId + " || " + ex.Message.ToString());
                }

            }
            _spreadsheetId = spreadsheetId;
        }
        public List<ExpandoObject> GetDataFromSheet(GoogleSheetParameters googleSheetParameters)
        {
            //System.Diagnostics.Debug.WriteLine(googleSheetParameters.ToString());
            googleSheetParameters = MakeGoogleSheetDataRangeColumnsZeroBased(googleSheetParameters);
            var range = $"{googleSheetParameters.SheetName}!{GetColumnName(googleSheetParameters.RangeColumnStart)}" +
                $"{googleSheetParameters.RangeRowStart}:{GetColumnName(googleSheetParameters.RangeColumnEnd)}{googleSheetParameters.RangeRowEnd}";
            string SI = googleSheetParameters.SearchID;
            SpreadsheetsResource.ValuesResource.GetRequest request =
                _sheetsService.Spreadsheets.Values.Get(_spreadsheetId, range);
            int counter = 0;
            var numberOfColumns = googleSheetParameters.RangeColumnEnd - googleSheetParameters.RangeColumnStart;
            var columnNames = new List<string>();
            var returnValues = new List<ExpandoObject>();

            if (!googleSheetParameters.FirstRowIsHeaders)
            {
                for (var i = 0; i <= numberOfColumns; i++)
                {
                    counter++;
                    columnNames.Add($"Column{i}");
                }
            }
            // System.Diagnostics.Debug.WriteLine(_spreadsheetId);
            if (_spreadsheetId == "180Heq5ra56fvtmiSG71lz8k8_06meS2X1Xmf9VsEb6g")
            {
                // dl.downloadedDetails = "Configuring CI records...";
                //  dl.setHideTimerInApplicationView4 = 10;
            }

            try
            {
                var response = request.Execute();


                //dl.downloadedDetails =dl.downloadedDetails!="Good to go"?"Getting ready...":dl.downloadedDetails;
                counter = 0;
                int rowCounter = 0;
                IList<IList<Object>> values = response.Values;
                if (values != null && values.Count > 0)
                {
                    foreach (var row in values)
                    {
                        if (googleSheetParameters.FirstRowIsHeaders && rowCounter == 0)
                        {
                            for (var i = 0; i <= numberOfColumns; i++)
                            {
                                columnNames.Add(row[i].ToString());
                            }
                            rowCounter++;
                            continue;
                        }
                        var expando = new ExpandoObject();
                        var expandoDict = expando as IDictionary<String, object>;
                        var columnCounter = 0;
                        foreach (var columnName in columnNames)
                        {
                            expandoDict.Add(columnName,
                                row[columnCounter].ToString());
                            columnCounter++;
                        }
                        returnValues.Add(expando);
                        rowCounter++;
                    }
                }
            }
            catch(Exception lied)
            {
                System.Diagnostics.Debug.WriteLine(lied.Message.ToString());
            }
            
            return returnValues;
        }
        private string GetColumnName(int index)
        {
            const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            var value = "";

            if (index >= letters.Length)
                value += letters[index / letters.Length - 1];

            value += letters[index % letters.Length];
            return value;
        }
        private GoogleSheetParameters MakeGoogleSheetDataRangeColumnsZeroBased(GoogleSheetParameters googleSheetParameters)
        {
            googleSheetParameters.RangeColumnStart = googleSheetParameters.RangeColumnStart - 1;
            googleSheetParameters.RangeColumnEnd = googleSheetParameters.RangeColumnEnd - 1;
            return googleSheetParameters;
        }

        private int GetSheetId(SheetsService service, string spreadSheetId, string spreadSheetName)
        {
            var spreadsheet = service.Spreadsheets.Get(spreadSheetId).Execute();
            var sheet = spreadsheet.Sheets.FirstOrDefault(s => s.Properties.Title == spreadSheetName);
            int sheetId = (int)sheet.Properties.SheetId;
            return sheetId;
        }
    }
    public class GoogleSheetCell
    {
        public string CellValue { get; set; }
        public bool IsBold { get; set; }
        public System.Drawing.Color BackgroundColor { get; set; } = System.Drawing.Color.White;
    }

    public class GoogleSheetParameters
    {
        public int RangeColumnStart { get; set; }
        public int RangeRowStart { get; set; }
        public int RangeColumnEnd { get; set; }
        public int RangeRowEnd { get; set; }
        public string SheetName { get; set; }
        public bool FirstRowIsHeaders { get; set; }
        public string SearchID { get; set; }
    }

    public class GoogleSheetRow
    {
        public GoogleSheetRow() => Cells = new List<GoogleSheetCell>();

        public List<GoogleSheetCell> Cells { get; set; }
    }
}
