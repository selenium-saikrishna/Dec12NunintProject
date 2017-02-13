using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dec12NunitProject.day25
{
    [TestFixture]
    public class FileDownload
    {
        [Test]
        public void DownloadTest()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "http://seleniumhq.org";
            driver.FindElement(By.LinkText("Download")).Click();
            driver.FindElement(By.LinkText("3.0.1")).Click();
            Thread.Sleep(3000);
            System.Diagnostics.Process.Start("c:\\users\\sai\\desktop\\download.exe");







        }
    }
}
