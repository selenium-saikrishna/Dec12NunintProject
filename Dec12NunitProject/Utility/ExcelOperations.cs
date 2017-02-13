using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.Utility
{
    public class ExcelOperations
    {
        public int GetRowCount(String path,int sheetno)
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open(path);
            Excel.Worksheet ws = wb.Sheets[sheetno];

            Excel.Range range = ws.UsedRange;
            int rowcount = range.Rows.Count;
            return rowcount;
        }

        public String GetCellData(Excel.Worksheet ws,int rowno,int colno)
        {
           

            Excel.Range range = ws.UsedRange;
            String celldata=range.Cells[rowno, colno].Value.ToString();
            return celldata;
        }

        public Excel.Worksheet GetSheet(String path,int sheetno)
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open(path);
           // exapp.Visible = true;
            Excel.Worksheet ws = wb.Sheets[sheetno];
            return ws;

        }

        public void WriteExcel(Excel.Worksheet ws,int rowno,int colno,String data)
        {
            
            ws.Cells[rowno, colno] = data;
            

        }

        public void SaveExcel(String path)
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open(path);
            wb.Save();
           // wb.Save();
            //exapp.Quit();

        }
    }
}
