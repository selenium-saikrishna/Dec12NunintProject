using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.day23
{
    [TestFixture]
    public class TestResult : BaseClass
    {
        [Test]
        public void ResultMethod()
        {
            Excel.Worksheet ws1 = eo.GetSheet(addemp,1);

            bool result = rs.vaidateteststeps(addemp, 1, 10);
            if (result == true)
                eo.WriteExcel(ws1, 2, 5, "Passed");
            else
                eo.WriteExcel(ws1, 2, 5, "Failed");

            eo.SaveExcel(addemp);
            ws1 = eo.GetSheet(delemp, 1);
            result = rs.vaidateteststeps(delemp, 1, 4);
            if (result == true)
                eo.WriteExcel(ws1, 3, 5, "Passed");
            else
                eo.WriteExcel(ws1, 3, 5, "Failed");

            eo.SaveExcel(delemp);
            ws1 = eo.GetSheet(dataengine, 2);
            bool flag=rs.vaildatetestcase(dataengine,2,5);
            if (flag == true)
                eo.WriteExcel(ws1, 2, 4, "Passed");
            else
                eo.WriteExcel(ws1, 2, 4, "Failed");

            eo.SaveExcel(dataengine);
        }
    }
}
