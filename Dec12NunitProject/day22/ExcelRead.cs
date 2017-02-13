using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace Dec12NunitProject.day22
{
    [TestFixture]
    public class ExcelRead
    {
        [Test]
        public void TestMethod()
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open("c:\\users\\sai\\desktop\\Book1.xlsx");
            Excel.Worksheet ws = wb.Sheets[1];

            Excel.Range range = ws.UsedRange;
            int rowcount = ws.Rows.Count;
            int colcount = ws.Columns.Count;
            for(int i=1; i<=rowcount;i++)
            {
                for(int j=1; j<=colcount;j++)
                {
                    if(range.Cells[i,j].Value!=null)
                    {
                        Console.Write(range.Cells[i, j].Value.ToString()+"   ");
                    }

                }
                Console.WriteLine();
            }

        }
    }
}
