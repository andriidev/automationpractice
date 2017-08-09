using AutomationPractice.PageObjects;
using AutomationPractice.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomationPractice.Steps
{
    [Binding]
    class AddProductSteps
    {
        private Driver driver = new Driver();
        private AddProductPopUpPage addProductPopUpPage = new AddProductPopUpPage();
        private QuickViewPopUpPage quickViewPopUpPage = new QuickViewPopUpPage();


        public AddProductSteps()
        {
            PageFactory.InitElements(driver, addProductPopUpPage);
            PageFactory.InitElements(driver, quickViewPopUpPage);
        }

        [When(@"I click '(.*)' in confirmation pop up")]
        public void WhenIClickInConfirmationPopUp(string btnName)
        {
            switch (btnName.ToLower())
            {
                case "proceed":
                    driver.WaitForElementVisible(By.CssSelector("div.button-container > a > span"));
                    addProductPopUpPage.ProceedToCheckoutBtn.Click();
                    break;
                case "continue shopping":
                    Thread.Sleep(1000);
                    addProductPopUpPage.ContinueShoppingBtn.Click();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [When(@"I set quantity to '(.*)' colour to '(.*)' select size '(.*)'")]
        public void WhenISetQuantityToColourToSelectSize(int quantity, int colorPos, string size)
        {
            driver.SwitchTo().Frame(0);
            quickViewPopUpPage.SetProductParameters(quantity, colorPos, size);
            driver.SwitchTo().DefaultContent();
        }

        [When(@"I click '(.*)' button on quickview card")]
        public void WhenIClickButtonOnQuickviewCard(string BtnName)
        {
            switch (BtnName.ToLower())
            {
                case "add to cart":
                    driver.SwitchTo().Frame(0);
                    quickViewPopUpPage.AddToCartBtnClick();
                    driver.SwitchTo().DefaultContent();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

    }
}
