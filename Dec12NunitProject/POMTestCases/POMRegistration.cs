using Dec12NunitProject.PageClasses;
using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.POMTestCases
{
    [TestFixture]
    public class POMRegistration
    {
        [Test]
        public void POM_Registration()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "http://newtours.demoaut.com";
            WelcomeMercurytours wmPage = new WelcomeMercurytours();
            PageFactory.InitElements(driver, wmPage);
            LeftMenu leftMenuPage = new LeftMenu();
            PageFactory.InitElements(driver, leftMenuPage);
            RegisterMercuryTours rmPage = new RegisterMercuryTours();
            PageFactory.InitElements(driver, rmPage);

            wmPage.Register();
            rmPage.ContactInformation();
            leftMenuPage.Home();
            wmPage.FindAFlight("tutorial", "tutorial");
















        }
    }
}
