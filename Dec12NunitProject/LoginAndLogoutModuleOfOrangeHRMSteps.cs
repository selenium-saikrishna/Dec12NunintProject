using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;

namespace Dec12NunitProject
{
    
    [Binding]
    public class LoginAndLogoutModuleOfOrangeHRMSteps
    {
        IWebDriver driver;
        [Given(@"the browser is launched and orangehrm url is navigated to")]
        public void GivenTheBrowserIsLaunchedAndOrangehrmUrlIsNavigatedTo()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://opensource.demo.orangehrmlive.com/";
        }
        
        [When(@"I enter (.*) and (.*)")]
        public void WhenIEnterAnd(string u, string p)
        {
            driver.FindElement(By.Id("txtUsername")).SendKeys(u);
            driver.FindElement(By.Id("txtPassword")).SendKeys(p);
        }
        
        [When(@"click on login button")]
        public void WhenClickOnLoginButton()
        {
            driver.FindElement(By.Id("btnLogin")).Click();
        }
        
        [Then(@"it should display (.*)")]
        public void ThenItShouldDisplay(string expmsg)
        {
            String actmsg = null; 
            if (expmsg.Equals("Invalid credentials"))
                actmsg = driver.FindElement(By.Id("spanMessage")).Text;
            else if (expmsg.Equals("Welcome Admin"))
                actmsg = driver.FindElement(By.Id("welcome")).Text;
            Assert.AreEqual(expmsg, actmsg);

        }
    }
}
