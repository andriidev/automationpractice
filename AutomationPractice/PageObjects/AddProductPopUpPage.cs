using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    class AddProductPopUpPage
    {
        //Elements
        [FindsBy(How = How.CssSelector, Using = "div.button-container > a > span")]
        public IWebElement ProceedToCheckoutBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".continue.btn.btn-default.button.exclusive-medium>span")]
        public IWebElement ContinueShoppingBtn { get; set; }
    }

}
