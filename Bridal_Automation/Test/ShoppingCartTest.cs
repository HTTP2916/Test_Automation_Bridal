using Bridal_Automation.Pages;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Bridal_Automation.Test
{
    public class ShoppingCartTest : BaseTest
    {
        // Init pages
        LoginPage loginPage;
        Homepage homepage;
        CategoryPage categoryPage;
        CartPage cartPage;

        // Init test
        public ShoppingCartTest(): base()
        {
            loginPage = new LoginPage(Browser);
            homepage = new Homepage(Browser);
            categoryPage = new CategoryPage(Browser);
            cartPage = new CartPage(Browser);
        }

        [Fact]
        public void VerifyAddToCart()
        {
            loginPage.Login();
            homepage.Go();
            homepage.AddToCartFirstProduct();

            // Navigate to Categories page
            categoryPage.SelectColorAndSize();

            // Get name
            string product = categoryPage.LblProductName.Text;

            categoryPage.ClickAddToCartButton();

            // Navigate to Shopping cart page and verify product will be displayed
            Assert.True(cartPage.LblProduct(product).Displayed);
            Dispose();
        }
    }
}
