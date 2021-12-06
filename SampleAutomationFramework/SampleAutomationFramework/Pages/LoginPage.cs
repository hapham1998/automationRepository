using Actuos_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
   public class LoginPage: BasePage
    {
        public LoginPage(Browser browser): base(browser)
        {
        }

        IWebElement btnLogin => Browser.Driver.FindElement(By.XPath("//a[contains(text(),'Log In')]"));
        IWebElement txtEmailAddress => Browser.Driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement txtPassword => Browser.Driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement btn_Login => Browser.Driver.FindElement(By.XPath("//span[contains(text(),'Login')]"));

        public void Login()
        {
            btnLogin.Click();
            txtEmailAddress.SendKeys("hapham@gmail.com");
            txtPassword.SendKeys("123456");
            btn_Login.Click();
        }
    }
}
