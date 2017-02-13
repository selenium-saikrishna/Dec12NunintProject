using Dec12NunitProject.Utility;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day23
{
     public class BaseClass
    {
        public static  IWebDriver driver;
        public Results rs = new Results();
        public   ExcelOperations eo = new ExcelOperations();
        public String dataengine = "C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\ExcelFiles\\DataDrivenEngine.xlsx";
        public String resultFolder = "C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\ResultExcelFiles\\";
        public String addemp = "C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\ExcelFiles\\AddEmployee.xlsx";
        public String delemp = "C:\\Users\\Sai\\Documents\\Visual Studio 2015\\Projects\\Dec12NunitProject\\Dec12NunitProject\\ExcelFiles\\DelEmployee.xlsx";
    }
}
