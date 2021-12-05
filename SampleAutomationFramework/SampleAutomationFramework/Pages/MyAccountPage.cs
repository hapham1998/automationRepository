using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
    public class MyAccountPage
    {
        IWebDriver Driver;
        public MyAccountPage(IWebDriver driver)
        {
            Driver = driver;
        }

        IWebElement editAccountLink => Driver.FindElement(By.XPath(""));

        public void ClickEditAccount()
        {
            editAccountLink.Click();
        }
    }
}
