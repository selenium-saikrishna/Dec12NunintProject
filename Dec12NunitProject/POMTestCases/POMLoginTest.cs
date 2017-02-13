using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.PageClasses
{
    [TestFixture]
    public class POMLoginTest
    {
        [Test]
        public void POMLogin()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "http://newtours.demoaut.com";
            WelcomeMercurytours wmPage = new WelcomeMercurytours();
            PageFactory.InitElements(driver, wmPage);
            wmPage.FindAFlight("admin", "admin");
        }
    }
}
