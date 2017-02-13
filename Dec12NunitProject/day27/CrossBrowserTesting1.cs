using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dec12NunitProject.day27
{
    [TestFixture]
    [Parallelizable]
    public class CrossBrowserTesting1 : BaseClass
    {
        [Test]
        [TestCaseSource(typeof(BaseClass),"browsertobeused")]
        public void CrossBrowserTest(String browser)
        {
            Console.Write(browser);
            setup(browser);
            Thread.Sleep(10000);

           // RemoteWebDriver 
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Url = "http://newtours.demoaut.com";
            driver.FindElement(By.LinkText("REGISTER")).Click();
            IWebElement drop = driver.FindElement(By.Name("country"));
            ReadOnlyCollection<IWebElement> dropdown = drop.FindElements(By.TagName("option"));
            Console.WriteLine(dropdown.Count);
            foreach (IWebElement x in dropdown)
            {
                x.Click();
                if (x.Selected)
                    Console.WriteLine(x.Text + " is active");
                else
                    Console.WriteLine(x.Text + " is inactive");
            }
            driver.Close();

        }


       /* public static Object[] getData()
        {
            Object[][] data = new Object[3][];
            data[0] = new Object[1];
            data[0][0] = "firefox";

            data[1] = new Object[1];
            data[1][0] = "chrome";

            data[2] = new Object[1];
            data[2][0] = "ie";

            return data;*/




        }
    }

