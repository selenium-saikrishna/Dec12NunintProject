using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel=Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.Utility
{
    public class Results
    {
        public bool vaidateteststeps(String path, int sheetno, int colno)
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open(path);
            Excel.Worksheet ws = wb.Sheets[sheetno];
            Excel.Range range = ws.UsedRange;
            int rowcount = range.Rows.Count;

            for (int i = 2; i <= rowcount; i++)
            {
                String result = range.Cells[i, colno].Value.ToString();
                if (result.Equals("Failed"))
                {
                    return false;
                }
            }
            return true;
        }

        public bool vaildatetestcase(String path, int sheetno, int colno)
        {

            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open(path);
            Excel.Worksheet ws = wb.Sheets[sheetno];
            Excel.Range range = ws.UsedRange;
            int rowcount = range.Rows.Count;

            for (int i = 2; i <= rowcount; i++)
            {
                String runmode = range.Cells[i, colno - 1].Value.ToString();
                String result = range.Cells[i, colno].Value.ToString();
                if (runmode.Equals("Y"))
                {
                    if (result.Equals("Failed"))
                        return false;
                }
            }
            return true;
        }
    }
}
