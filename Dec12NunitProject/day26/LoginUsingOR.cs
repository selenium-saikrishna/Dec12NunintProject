using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.day26

{
    [TestFixture]
    public class LoginUsingOR
    {
        [Test]
        public void ORMethod()
        {
            Excel.Application exapp = new Excel.Application();
            Excel.Workbook wb = exapp.Workbooks.Open("C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\OR\\OR.xlsx");
            Excel.Worksheet ws = wb.Sheets[1];

            Excel.Range range = ws.UsedRange;
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "http://opensource.demo.orangehrmlive.com/index.php/auth/login";
            driver.FindElement(By.Id(range.Cells[2, 2].Value().ToString())).SendKeys("Admin");
            driver.FindElement(By.XPath(range.Cells[3, 3].Value().ToString())).SendKeys("admin");
            driver.FindElement(By.Id(range.Cells[4, 2].Value().ToString())).Click();



        }
    }
}
