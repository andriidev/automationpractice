using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    class ShoppingCartPage
    {
        //Elements
        [FindsBy(How = How.CssSelector, Using = ".button.btn.btn-default.standard-checkout.button-medium>span")]
        public IWebElement ProceedToCheckoutBtn { get; set; }
    }
}
