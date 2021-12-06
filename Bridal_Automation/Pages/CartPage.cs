using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridal_Automation.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(Browser browser) : base(browser)
        {
        }

        #region Elements
        public IWebElement LblProduct(string name) =>
            Browser.XpathGetElement($"//td[.//a[text()='{name}']]");
        #endregion
    }
}
