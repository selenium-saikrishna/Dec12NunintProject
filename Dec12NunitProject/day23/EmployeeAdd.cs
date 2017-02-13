using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.day23
{
    [TestFixture]
    public class EmployeeAdd : BaseClass
    {
        
         
        [Test]
        public void DatadrivenTesting()
        {
            Excel.Worksheet ws = eo.GetSheet(addemp, 1);
            String runMode=eo.GetCellData(ws, 2, 4) ;
            if (runMode.Equals("N"))
                Assert.Ignore();
            driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b")).Click();



            int rowcount = eo.GetRowCount(addemp,1);
            
            for (int i = 2; i <= rowcount; i++)
            {
                driver.FindElement(By.Id("menu_pim_addEmployee")).Click();
                driver.FindElement(By.Id("firstName")).SendKeys(eo.GetCellData(ws,i,1));
                driver.FindElement(By.Id("middleName")).SendKeys(eo.GetCellData(ws, i, 2));
                driver.FindElement(By.Id("lastName")).SendKeys(eo.GetCellData(ws, i, 3));
                driver.FindElement(By.Id("employeeId")).Clear();
                driver.FindElement(By.Id("employeeId")).SendKeys(eo.GetCellData(ws, i, 4));
                String logindetails = eo.GetCellData(ws, i, 5);
                IWebElement check = driver.FindElement(By.Id("chkLogin"));
                if (logindetails.Equals("Y"))
                {
                    if (!check.Selected)
                    {
                        check.Click();
                    }
                    driver.FindElement(By.Id("user_name")).SendKeys(eo.GetCellData(ws, i, 6));
                    driver.FindElement(By.Id("user_password")).SendKeys(eo.GetCellData(ws, i, 7));
                    driver.FindElement(By.Id("re_password")).SendKeys(eo.GetCellData(ws, i, 8));
                    driver.FindElement(By.Id("status")).SendKeys(eo.GetCellData(ws, i, 9));
                }
                else
                {
                    if (check.Selected)
                        check.Click();
                }
                driver.FindElement(By.Id("btnSave")).Click();
                String acttext = driver.FindElement(By.XPath("//*[@id='pdMainContainer']/div[1]/h1")).Text;
                if (acttext.Equals("Personal Details"))
                    eo.WriteExcel(ws, i, 10, "Passed");
                else
                    eo.WriteExcel(ws, i, 10, "Failed");
            }
            eo.SaveExcel(addemp);
            //eo.SaveExcel(dataengine, resultFolder + "dataengine.xlsx");

            

           // eo.SaveExcel(dataengine);


        }
      }
   }
