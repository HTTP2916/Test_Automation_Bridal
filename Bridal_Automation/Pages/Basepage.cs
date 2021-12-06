using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridal_Automation.Pages
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