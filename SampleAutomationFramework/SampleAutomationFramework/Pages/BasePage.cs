using Actuos_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
    public class BasePage
    {
       public Browser Browser;

        public BasePage(Browser browser)
        {
            Browser = browser;
        }
    }
}
