using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AutomationPractice.PageObjects
{
    class MainPage
    {
        //Elements
        [FindsBy(How = How.CssSelector, Using = ".logo.img-responsive")]
        public IWebElement ActiveTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".login")]
        public IWebElement SignIn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".account>span")]
        public IWebElement ViewMyAccount { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".logout")]
        public IWebElement LogoutButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".blockbestsellers")]
        public IWebElement BestSellersButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".homefeatured")]
        public IWebElement PopularButton { get; set; }
        //Product
        [FindsBy(How = How.CssSelector, Using = ".price-percent-reduction")]
        public IWebElement ItemDiscount { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".facebook")]
        public IWebElement ItemImage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".button.ajax_add_to_cart_button.btn.btn-default>span")]
        public IWebElement AddToCartBtn { get; set; }
        


        //Actions
        public void LogoutBouttnClick()
        {
            LogoutButton.Click();
        }
    }
}
