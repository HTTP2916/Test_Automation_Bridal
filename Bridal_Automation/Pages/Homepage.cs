using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridal_Automation.Pages
{
    public class Homepage : BasePage
    {
        public Homepage(Browser browser) : base(browser)
        {

        }

        #region Elements
        // Xpath
        public IWebElement BtnHome => Browser.XpathGetElement("//span[contains(text(),'Home')]");
        public IWebElement LblTitle => Browser.XpathGetElement("//h2[contains(text(),'New Arrivals')]");
        public IWebElement BtnFirstAddToCart => Browser.XpathGetElement("(//li[@class='item']//span[text()='Add to Cart'])[1]");

        #endregion

        #region Methods
        public void Go()
        {
            BtnHome.Click();
        }

        public void AddToCartFirstProduct()
        {
            BtnFirstAddToCart.Click();
        }
        #endregion
    }
}
