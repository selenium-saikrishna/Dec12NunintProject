using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day23
{
    [TestFixture]
    public class AppLogin : BaseClass
    {
        

        [Test]
        public void AppLaunch()
        {
            driver = new ChromeDriver();
            driver.Url = "http://opensource.demo.orangehrmlive.com/index.php/auth/login";
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(30));
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin");
            driver.FindElement(By.Id("btnLogin")).Click();
            
            
        }
    }
   }

