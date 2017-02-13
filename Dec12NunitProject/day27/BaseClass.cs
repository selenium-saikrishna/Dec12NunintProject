using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.day27
{
    
    public  class BaseClass
    {
        public IWebDriver driver = null;
        public DesiredCapabilities cap = null;

        public void setup(String browser)
        {
            if (browser.Equals("chrome"))
            {
                cap = DesiredCapabilities.Chrome();
                cap.SetCapability(CapabilityType.BrowserName, "chrome");
                
                cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            }
            else if(browser.Equals("firefox"))
            {
                cap = DesiredCapabilities.Firefox();
                cap.SetCapability(CapabilityType.BrowserName, "firefox");

                cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));
            }
            else if(browser.Equals("ie"))
            {
                cap = DesiredCapabilities.InternetExplorer();
                cap.SetCapability(CapabilityType.BrowserName, "internet explorer");

                cap.SetCapability(CapabilityType.Platform, new Platform(PlatformType.Windows));

            }
            driver = new RemoteWebDriver(new Uri("http://localhost:4444/wd/hub"), cap);


        }

        public static IEnumerable<String> browsertobeused()
        {
            String[] browser = { "firefox", "chrome", "ie" };
            foreach (String x in browser)
                yield return x;
        }
             
    }
}
