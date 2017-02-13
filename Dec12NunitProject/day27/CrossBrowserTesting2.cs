using NUnit.Framework;
using OpenQA.Selenium;
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
    public class CrossBrowserTesting2 : BaseClass
    {
        [TestCaseSource(typeof(BaseClass), "browsertobeused")]
        public void CrossBrowserTestLinks(String browser)
        {
            Console.Write(browser);
            setup(browser);
            Thread.Sleep(10000);

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            driver.Url = "http://newtours.demoaut.com";
            ReadOnlyCollection<IWebElement> links = driver.FindElements(By.TagName("a"));
            for(int i=0;i<links.Count;i++)
            {
                links[i].Click();
                driver.Navigate().Back();
                links = driver.FindElements(By.TagName("a"));

            }

        }
    }
       
    }
