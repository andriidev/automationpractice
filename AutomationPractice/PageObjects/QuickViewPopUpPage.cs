using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    class QuickViewPopUpPage
    {
        //Elements
        [FindsBy(How = How.CssSelector, Using = ".btn.btn-default.button-minus.product_quantity_down>span")]
        public IWebElement ProductQuantityMinusBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#quantity_wanted_p > a.btn.btn-default.button-plus.product_quantity_up > span")]
        public IWebElement ProductQuantityPlusBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#quantity_wanted")]
        public IWebElement ProductQuantityInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#group_1")]
        public IWebElement ProductSizeDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".color_pick")]
        public IList<IWebElement> ProductColors { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".exclusive")]
        public IWebElement AddToCartBtn { get; set; }

        //Actions
        public void ProductQuantityMinusClick()
        {
            ProductQuantityMinusBtn.Click();
        }

        public void ProductQuantityPlusClick()
        {
            ProductQuantityPlusBtn.Click();
        }

        public void SelectProdSize(string size)
        {
            new SelectElement(ProductSizeDDL).SelectByText(size);
        }

        public void SelectColorByPosition(int colorPosition)
        {
            ProductColors[colorPosition].Click();
        }

        public void SetProductParameters(int quantity, int colorPos, string size)
        {
            for (int i = 1; i < quantity; i++)
            {
                ProductQuantityPlusClick();
            }
            SelectProdSize(size);
            SelectColorByPosition(colorPos);
        }

        public void AddToCartBtnClick()
        {
            AddToCartBtn.Click();
        }
    }
}
