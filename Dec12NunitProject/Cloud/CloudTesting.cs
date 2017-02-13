using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.Cloud
{
    [TestFixture]
    [Parallelizable]
    public class CloudTesting : BaseClass
    {
        [Test]
        [TestCaseSource(typeof(BaseClass), "browsertobeused")]
        public void TestCloud(String browser)
        {
            setup(browser);


            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://ondemand.saucelabs.com:80/wd/hub"), caps, TimeSpan.FromSeconds(600));
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
    }
}
