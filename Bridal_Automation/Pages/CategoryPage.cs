using Bridal_Automation_WebDriver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bridal_Automation.Pages
{
    public class CategoryPage : BasePage
    {
        public CategoryPage(Browser browser) : base(browser)
        {

        }

        #region Elements
        // Xpath
        public By DdlColor => By.XPath("//tr[.//td[contains(text(),'color')]]//select");
        public By DdlSize => By.XPath("//tr[.//td[contains(text(),'size')]]//select");

        public IWebElement LblProductName => Browser.XpathGetElement("//div[@class='product_show_r']//h1");
        public IWebElement LblColor => Browser.XpathGetElement("//h4[@id='notevariation']/span[1]");
        public IWebElement LblSize => Browser.XpathGetElement("//h4[@id='notevariation']/span[2]");
        public IWebElement LblTitle => Browser.XpathGetElement("//span[text()='Categories']");
        
        public IWebElement BtnAddToCart => Browser.XpathGetElement("//a[@type='submit']//span[text()='Add to Cart']");
        
        #endregion

        #region Methods
        public void ClickAddToCartButton()
        {
            BtnAddToCart.Click();
        }

        public void SelectColorAndSize()
        {
            if (Browser.CheckElementExits(DdlColor))
                Browser.SelectByIndex(DdlColor, 1);
            if (Browser.CheckElementExits(DdlSize))
                Browser.SelectByIndex(DdlSize, 1);
        }
        #endregion
    }
}
