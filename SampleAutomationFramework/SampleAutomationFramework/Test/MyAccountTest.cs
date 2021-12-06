using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SampleAutomationFramework.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace SampleAutomationFramework.Test
{
   public class MyAccountTest: BaseTest
    {
        LoginPage loginPage;
        public MyAccountTest()
        {
            loginPage = new LoginPage(Browser);
        }

        [Fact]
        public void Accounttest()
        {

        }
    }
}
