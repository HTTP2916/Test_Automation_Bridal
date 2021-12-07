using Bridal_Automation.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using Xunit;

namespace Bridal_Automation.Test
{
    public class LoginTest: BaseTest
    {
        readonly LoginPage loginPage;
        public LoginTest():base()
        {
            loginPage = new LoginPage(Browser);
        }

        [Fact]
        public void DoLogin()
        {
            loginPage.Login();
        }
    }
}