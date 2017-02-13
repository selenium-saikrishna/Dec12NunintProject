using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dec12NunitProject.day26
{
    class LoginKeywords
    {
        FirefoxDriver driver;
        public void launchBrowser()
        {
            driver = new FirefoxDriver();
        }
        public void navigate()
        {
            driver.Url = "http://opensource.demo.orangehrmlive.com/index.php/auth/login";
        }
        public void enterUsername()
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys("Admin");

        }
        public void enterPassword()
        {
            driver.FindElement(By.Id("txtPassword")).SendKeys("admin");
        }
        public void clickLogin()
        {
            Thread.Sleep(3000);
            driver.FindElement(By.Id("btnLogin")).Click(); ;
        }

    }
}
