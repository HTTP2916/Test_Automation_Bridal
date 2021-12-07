using Bridal_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bridal_Automation.Test
{
    public class HomepageTest : BaseTest
    {
        readonly Homepage homepage;
        public HomepageTest(): base()
        {
            homepage = new Homepage(Browser);
        }

        public void VerifyGoToHomepage()
        {
            homepage.Go();
            Assert.True(homepage.LblTitle.Displayed);
        }
    }
}