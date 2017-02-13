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
    public class Fileupload
    {
        [Test]
        public void UploadTest()
        {
            FirefoxDriver driver = new FirefoxDriver();
            driver.Url = "http://imgur.com";
            driver.FindElement(By.ClassName("upload-btn-text")).Click();
            driver.FindElement(By.ClassName("browse-btn")).Click();
            Thread.Sleep(2000);
            System.Diagnostics.Process.Start("c:\\users\\sai\\desktop\\upload.exe");

        }
    }
}
