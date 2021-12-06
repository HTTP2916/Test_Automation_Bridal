using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using static Bridal_Automation_WebDriver.Browser;

namespace Bridal_Automation_WebDriver
{
    public class Browser
    {
        public IWebDriver Driver;
        public WebDriverWait wait;
        public Browser(BrowserType type)
        {
            Driver = BrowserFactory.GetWebDriver(type);
            wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
        }

        public IWebElement XpathGetElement(string element)
        {
            return Driver.FindElement(By.XPath(element));
        }

        public enum BrowserType
        {
            Chrome, 
            Firefox
        }

        public void GoToUrl(string url)
        {
            Driver.Manage().Window.Maximize();
            Driver.Url = url;
        }

        public void Wait( By element, int timeout = 5)
        {
            wait.Until(Driver => Driver.FindElement(element));
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(timeout);
        }

        public void SelectByIndex(By xpath, int index)
        {
            SelectElement dropdown = new SelectElement(Driver.FindElement(xpath));
            dropdown.SelectByIndex(index);
        }

        public Boolean CheckElementExits(By xpath)
        {
            try
            {
                return Driver.FindElement(xpath).Displayed;
            }
            catch ( NoSuchElementException e)
            {
                return false;
            }
        }
    }
    
    public class BrowserFactory
    {
        public static IWebDriver GetWebDriver(BrowserType type)
        {
            IWebDriver Driver = null;
            string driverFolder = string.Empty;
            switch (type)
            {
                case BrowserType.Chrome:
                    driverFolder = Directory.GetCurrentDirectory() + @"\WebDrivers\" + $"{type}";
                    Driver = new ChromeDriver();
                    break;
                case BrowserType.Firefox:
                    driverFolder = Directory.GetCurrentDirectory() + @"\WebDrivers\" + $"{type}";
                    Driver = new FirefoxDriver();
                    break;
                default:
                    throw new Exception("");
            }
            return Driver;
        }
    }
}