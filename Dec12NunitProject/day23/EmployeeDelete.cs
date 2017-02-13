using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Dec12NunitProject.day23
{
    [TestFixture]
    public class EmployeeDelete : BaseClass
    {
        [Test]
        public void EmpDel()

        {
            Excel.Worksheet ws = eo.GetSheet(delemp, 1);
            String runMode = eo.GetCellData(ws, 3, 4);
            if (runMode.Equals("N"))
                Assert.Ignore();
            driver.FindElement(By.XPath("//*[@id='menu_pim_viewPimModule']/b")).Click();
            driver.FindElement(By.Id("menu_pim_viewEmployeeList")).Click();
            

           
            int rowcount = eo.GetRowCount(delemp, 1);
            
            for (int i = 2; i <= rowcount; i++)
            {
                bool flag = false;
                IWebElement table = driver.FindElement(By.Id("resultTable"));
                ReadOnlyCollection<IWebElement> rows = table.FindElements(By.TagName("tr"));
                for (int r = 0; r < rows.Count; r++)
                {
                    ReadOnlyCollection<IWebElement> cols = rows[r].FindElements(By.TagName("td"));
                    for (int c = 0; c < cols.Count; c++)
                    {
                        if (cols[c].Text.Equals(eo.GetCellData(ws, i, 1)))
                        {
                            cols[c - 1].FindElement(By.TagName("input")).Click();
                            flag = true;
                            break;
                        }
                    }
                    if (flag ==true)
                            break;
                }
            }
            driver.FindElement(By.Id("btnDelete")).Click();
            driver.FindElement(By.Id("dialogDeleteBtn")).Click();

            for(int i=2;i<=rowcount;i++)
            {
                String empid = eo.GetCellData(ws, i, 1);
                driver.FindElement(By.Id("empsearch_id")).Clear();
                driver.FindElement(By.Id("empsearch_id")).SendKeys(empid);
                driver.FindElement(By.Id("searchBtn")).Click();
                String actmsg=driver.FindElement(By.XPath("//*[@id='resultTable']/tbody/tr/td")).Text;
                eo.WriteExcel(ws, i, 3, actmsg);
                String expmsg = eo.GetCellData(ws, i, 2);
                if (expmsg.Equals(actmsg))
                    eo.WriteExcel(ws, i, 4,"Passed");
                else
                    eo.WriteExcel(ws, i, 4, "Failed");
            }




            eo.SaveExcel(delemp);

            

            //eo.SaveExcel(dataengine);



        }
        
    }
}

