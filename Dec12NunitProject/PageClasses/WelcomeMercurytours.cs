
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.PageClasses
{
    public class WelcomeMercurytours
    {
        [FindsBy(How = How.Name,Using ="userName")]
        IWebElement userName;
        [FindsBy(How = How.Name, Using = "password")]
        IWebElement password;
        [FindsBy(How = How.Name, Using = "login")]
        IWebElement signin;
        public void FindAFlight(String userName,String password)
        {
            this.userName.SendKeys(userName);
            this.password.SendKeys(password);
            signin.Click();
        }




        [FindsBy(How = How.LinkText, Using = "your destination")]
        IWebElement Linkdestination;
        public void Destinations()
        {
            Linkdestination.Click();
        }


        [FindsBy(How = How.LinkText, Using = "featured vacation destinations")]
        IWebElement LinkVacations;
        public void Vacations()
        {
            LinkVacations.Click();
        }


        [FindsBy(How = How.LinkText, Using = "Register here")]
        IWebElement Linkregister;
        public void Register()
        {
            Linkregister.Click();
        }
















    }
}
