using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleAutomationFramework.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleAutomationFramework.Test
{
    public class LoginTest: BaseTest
    {
        readonly LoginPage loginPage;
        public LoginTest()
        {
            loginPage = new LoginPage(Browser);
        }

        [Fact]
        public void TestLogin()
        {
            loginPage.Login();
        }
    }
}
