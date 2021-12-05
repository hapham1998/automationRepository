using Actuos_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
    public class BasePage
    {
       public IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
    }
}
