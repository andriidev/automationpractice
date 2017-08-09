using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using Xunit;

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
        [FindsBy(How = How.CssSelector, Using = "#search_query_top")]
        public IWebElement SearchInput { get; set; }
        [FindsBy(How = How.Name, Using = "submit_search")]
        public IWebElement SearchBtn { get; set; }
        
        //Cart drop down
        [FindsBy(How = How.CssSelector, Using = "#button_order_cart>span")]
        public IWebElement CartCheckout { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".shopping_cart>a")]
        public IWebElement CartDD { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='header']//dl/dt/div/span")]
        public IWebElement ProductSum { get; set; }

        //Product Grid
        [FindsBy(How = How.CssSelector, Using = ".price-percent-reduction")]
        public IWebElement ItemDiscount { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#selectProductSort")]
        public IWebElement SortGridDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".facebook")]
        public IWebElement ItemImage { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".button.ajax_add_to_cart_button.btn.btn-default>span")]
        public IWebElement AddToCartBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".quick-view-mobile")]
        public IList<IWebElement> QuickViewBtnsList { get; set; }
        [FindsBy(How = How.CssSelector, Using = "div.right-block > div.content_price > span")]
        public IList<IWebElement> ProdutcsPriceList { get; set; }





        //Actions
        public void LogoutBouttnClick()
        {
            LogoutButton.Click();
        }

        public void SearchBtnClick()
        {
            SearchBtn.Click();
        }

        public void SearchSendNewKeys(string searchValue)
        {
            SearchInput.Clear();
            SearchInput.SendKeys(searchValue);
        }

        public void SearchByText(string searchValue)
        {
            SearchSendNewKeys(searchValue);
            SearchBtnClick();
        }
        public void SortGridBy(string sortBy)
        {
            new SelectElement(SortGridDDL).SelectByText(sortBy);
        }

        public void VerifySortingInGrid(string sortDirection)
        {
            int productsNumber = ProdutcsPriceList.Count;
            double[] productPricesAct = new double[productsNumber];
            double[] productPricesExp = new double[productsNumber];
            for (int i = 0; i < productsNumber; i++)
            {
                var ololo = ProdutcsPriceList[i].Text;
                string[] price = ProdutcsPriceList[i].Text.Split('$');
                productPricesAct[i] = Convert.ToDouble(price[1]);
                productPricesExp[i] = Convert.ToDouble(price[1]);
            }

            switch (sortDirection)
            {
                case "ascending":
                    Array.Sort(productPricesExp);
                    break;
                case "descending":
                    Array.Sort(productPricesExp);
                    Array.Reverse(productPricesExp);
                    break;

                default:

                    break;
            }

            Assert.Equal(productPricesExp, productPricesAct);
        }

        public void QuickViewProductClick(int productNumber)
        {
            QuickViewBtnsList[productNumber].Click();
        }
    }
}
