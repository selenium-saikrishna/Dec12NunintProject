using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.PageClasses
{
    class RegisterMercuryTours
    {
        [FindsBy(How = How.Name, Using = "firstName")]
        IWebElement firstName;
        [FindsBy(How = How.Name, Using = "lastName")]
        IWebElement lastName;
        [FindsBy(How = How.Name, Using = "phone")]
        IWebElement phone;
        [FindsBy(How = How.Name, Using = "userName")]
        IWebElement email;
        [FindsBy(How = How.Name, Using = "address1")]
        IWebElement address;
        [FindsBy(How = How.Name, Using = "city")]
        IWebElement city;
        [FindsBy(How = How.Name, Using = "state")]
        IWebElement state;
        [FindsBy(How = How.Name, Using = "postalCode")]
        IWebElement postalCode;
        [FindsBy(How = How.Name, Using = "country")]
        IWebElement country;
        [FindsBy(How = How.Name, Using = "email")]
        IWebElement userName;
        [FindsBy(How = How.Name, Using = "password")]
        IWebElement password;
        [FindsBy(How = How.Name, Using = "confirmPassword")]
        IWebElement confirmPassword;
        [FindsBy(How = How.Name, Using = "register")]
        IWebElement submit;
        public void ContactInformation()
        {
            firstName.SendKeys("Sai");
            lastName.SendKeys("Krishna");
            phone.SendKeys("22222222");
            email.SendKeys("Sai@gmail.com");
            address.SendKeys("12-3-3-");
            city.SendKeys("Hyd");
            state.SendKeys("TS");
            postalCode.SendKeys("111-222-333");
            country.SendKeys("INDIA");
            userName.SendKeys("tutorial");
            password.SendKeys("tutorial");
            confirmPassword.SendKeys("tutorial");
            submit.Click();
        }

    }
}
