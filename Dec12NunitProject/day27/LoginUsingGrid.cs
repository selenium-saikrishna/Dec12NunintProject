using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day27
{
    [TestFixture]
    public class LoginUsingGrid
    {
        [Test]
        public void GridTest1()
        {
            DesiredCapabilities cap = new DesiredCapabilities();
            cap = DesiredCapabilities.Chrome();
            cap.SetCapability(CapabilityType.BrowserName, "chrome");
            //cap.SetCapability(CapabilityType.Version, "54.");
            cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            RemoteWebDriver driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);
            driver.Url = "http://opensource.demo.orangehrmlive.com/";
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin");
            driver.FindElement(By.Id("btnLogin")).Click();
        }
    }
}
