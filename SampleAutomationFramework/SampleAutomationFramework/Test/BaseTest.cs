using Actuos_WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using static Actuos_WebDriver.Browser;

namespace SampleAutomationFramework.Test
{
     public class BaseTest: IDisposable
    {
       // public IWebDriver Driver;
        public Browser Browser;
        public BaseTest()
        {
            Browser = new Browser(GetBrowserType(), GetBrowerUrl());
        }

        public BrowserType GetBrowserType()
        {
            var testhost = ConfigurationManager.AppSettings["browser"].ToString();
            Enum.TryParse(testhost, out BrowserType type);
            return type;
        }

        public string GetBrowerUrl()
        {
            var browserUrl = ConfigurationManager.AppSettings["url"].ToString();
            return browserUrl;
        }
        public void Dispose()
        {
            Browser.Driver.Quit();
        }
    }
}
