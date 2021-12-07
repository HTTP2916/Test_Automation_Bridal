using Bridal_Automation.Constants;
using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using static Bridal_Automation_WebDriver.Browser;

namespace Bridal_Automation.Test
{
    public class BaseTest: IDisposable
    {
        public Browser Browser;
        public BaseTest()
        {
            Browser = new Browser(GetBrowserType());
            Browser.GoToUrl(Config.BridalURL);
        }

        public BrowserType GetBrowserType()
        {
            var testHost = Config.ChromeBrowser;
            //var testHost = ConfigurationManager.AppSettings[Item.browser.ToString()].ToString();
            Enum.TryParse(testHost, out BrowserType type);
            return type;
        }

        private enum Item
        {
            browser,
            url,
            email,
            password
        } 

        public void Dispose()
        {
            Browser.Driver.Close();
        }
    }
}
