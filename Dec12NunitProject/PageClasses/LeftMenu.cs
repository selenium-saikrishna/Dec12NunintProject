using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.PageClasses
{
    class LeftMenu
    {
        [FindsBy(How = How.LinkText, Using = "Home")]
        IWebElement LinkHome;
        public void Home()
        {
            LinkHome.Click();
        }

        [FindsBy(How = How.LinkText, Using = "Flights")]
        IWebElement LinkFlights;
        public void Flights()
        {
            LinkFlights.Click();
        }


        [FindsBy(How = How.LinkText, Using = "Hotels")]
        IWebElement LinkHotels;
        public void Hotels()
        {
            LinkHotels.Click();
        }

        [FindsBy(How = How.LinkText, Using = "Car Rentals")]
        IWebElement LinkCarRentals;
        public void CarRentals()
        {
            LinkCarRentals.Click();
        }

        [FindsBy(How = How.LinkText, Using = "Cruises")]
        IWebElement LinkCruises;
        public void Cruises()
        {
            LinkCruises.Click();
        }

        [FindsBy(How = How.LinkText, Using = "Destinations")]
        IWebElement LinkDestinations;
        public void Destinations()
        {
            LinkDestinations.Click();
        }

        [FindsBy(How = How.LinkText, Using = "Vacations")]
        IWebElement LinkVacations;
        public void Vacations()
        {
            LinkVacations.Click();
        }

    }
}
