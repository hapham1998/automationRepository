using Actuos_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
    public class MyAccountPage : BasePage
    {
        
        public MyAccountPage(Browser browser) : base(browser)
        {
            
        }

        IWebElement editAccountLink => Browser.Driver.FindElement(By.XPath(""));

        public void ClickEditAccount()
        {
            editAccountLink.Click();
        }
    }
}
