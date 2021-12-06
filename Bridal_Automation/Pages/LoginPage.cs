using Bridal_Automation.Constants;
using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Bridal_Automation.Pages
{
    public class LoginPage: BasePage
    {
        public LoginPage(Browser browser): base(browser)
        {
            Browser = browser;
        }

        IWebElement lnkLogin => Browser.XpathGetElement("//a[text()='Log In']");
        IWebElement txtEmail => Browser.XpathGetElement("//input[@name='email']");
        IWebElement txtPassword => Browser.XpathGetElement("//input[@name='password']");
        IWebElement btnLogin => Browser.XpathGetElement("//span[text()='Login']");

        public void Login()
        {
            lnkLogin.Click();
            txtEmail.SendKeys(Config.Email);
            txtPassword.SendKeys(Config.Password);
            btnLogin.Click();
        }
    }
}