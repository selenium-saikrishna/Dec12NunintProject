using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec12NunitProject.Cloud
{
    public class BaseClass
    {
        public DesiredCapabilities caps = null;
        public void setup(String browser)
        {
            if (browser.Equals("edge"))
            {
                caps = new DesiredCapabilities();
                caps.SetCapability("browserName", "MicrosoftEdge");
                caps.SetCapability("platform", "Windows 10");
                caps.SetCapability("version", "14.14393");
            }
            else if (browser.Equals("firefox"))
            {
                caps = new DesiredCapabilities();
                caps.SetCapability("browserName", "Firefox");
                caps.SetCapability("platform", "Linux");
                caps.SetCapability("version", "45.0");
            }
            else if (browser.Equals("safari"))
            {
                caps = new DesiredCapabilities();
                caps.SetCapability("browserName", "Safari");
                caps.SetCapability("platform", "macOS 10.12");
                caps.SetCapability("version", "10.0");
            }
            caps.SetCapability("username", "softqcloud");
            caps.SetCapability("accessKey", "5dbb6fc1-bb88-4d5b-b3cc-4ba8b360263b");
        }

        public static IEnumerable<String> browsertobeused()
        {
            String[] browser = { "firefox", "edge", "safari" };
            foreach (String x in browser)
                yield return x;
        }

    }
}
