using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using static Actuos_WebDriver.Browser;
using System.IO;
using OpenQA.Selenium.Chrome;

namespace Actuos_WebDriver
{
    public class Browser
    {
        public IWebDriver Driver;
        public Browser(BrowserType type, string driverUrl)
        {
            Driver = BrowserFactory.GetWebDriver(type);
            Driver.Url = driverUrl;
        }

        public void GoToPage()
        {
            Driver.Url = "";
        }
        public enum BrowserType
        {
            Chrome, FireFox, Safari
        }
    }

    public class BrowserFactory
    {
        public static IWebDriver GetWebDriver(BrowserType type)
        {
            IWebDriver Driver = null;
            string driverFolder = string.Empty;
            switch (type)
            {
                case BrowserType.Chrome:
                    driverFolder = Directory.GetCurrentDirectory() + @"\WebDrivers\" + $"{type}";
                    Driver = new ChromeDriver();
                    //Driver.Url = "https://bridal.miiduu.com/";
                    break;
                default:
                    throw new Exception("You need to pass your browser");
            }
            return Driver;
        }
    }
}
