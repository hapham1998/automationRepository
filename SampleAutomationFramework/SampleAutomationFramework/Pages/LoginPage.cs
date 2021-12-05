using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleAutomationFramework.Pages
{
   public class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver): base(driver)
        {
        }

        IWebElement btnLogin => Driver.FindElement(By.XPath("//a[contains(text(),'Log In')]"));
        IWebElement txtEmailAddress => Driver.FindElement(By.XPath("//input[@name='email']"));
        IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@name='password']"));
        IWebElement btn_Login => Driver.FindElement(By.XPath("//span[contains(text(),'Login')]"));

        public void Login()
        {
            btnLogin.Click();
            txtEmailAddress.SendKeys("hapham@gmail.com");
            txtPassword.SendKeys("123456");
            btn_Login.Click();
        }
    }
}
