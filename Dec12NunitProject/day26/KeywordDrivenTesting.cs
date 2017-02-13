using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.day26
{
    [TestFixture]
    public class KeywordDrivenTesting
    {
        [Test]
        public void KeywordTest()
        {
            LoginKeywords keys = new LoginKeywords();
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open("C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\Keywords\\LoginKeywords.xlsx");
            Excel.Worksheet ws = wb.Sheets[1];

            Excel.Range range = ws.UsedRange;
            int rowcount = range.Rows.Count;
            for(int i=2;i<=rowcount;i++)
            {
                String runmode=range.Cells[i,5].Value.ToString();
                if(runmode.Equals("Y"))
                {
                    String keyword= range.Cells[i, 4].Value.ToString();
                    Console.WriteLine(keyword);
                    if (keyword.Equals("launchBrowser"))
                        keys.launchBrowser();
                    else if (keyword.Equals("navigate"))
                        keys.navigate();
                    else if (keyword.Equals("enterUsername"))
                        keys.enterUsername();
                    else if (keyword.Equals("enterPassword"))
                        keys.enterPassword();
                    else if (keyword.Equals("clickLogin"))
                        keys.clickLogin();

                }
            }
        }
    }
}
