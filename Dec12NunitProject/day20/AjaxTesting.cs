using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dec12NunitProject.day20
{
    [TestFixture]
    public class AjaxTesting
    {

        FirefoxDriver driver;
        [SetUp]
        public void LaunchApp()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://google.com";
        }
        [Test]
        public void AjaxTest()
        {
            driver.FindElement(By.Name("q")).SendKeys("selenium");
            Thread.Sleep(2000);
            ReadOnlyCollection<IWebElement> ajax=driver.FindElements(By.XPath("//*[starts-with(@id,'sbse')]/div[2]"));
            foreach (IWebElement x in ajax)
                Console.WriteLine(x.Text);     
        }
        [TearDown]
        public void CloseApp()
        {
            driver.Quit();
        }
    }
}
