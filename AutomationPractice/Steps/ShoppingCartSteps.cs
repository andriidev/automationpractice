using AutomationPractice.PageObjects;
using AutomationPractice.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using Xunit;

namespace AutomationPractice.Steps
{
    [Binding]
    class ShoppingCartSteps
    {
        private Driver driver = new Driver();
        private ShoppingCartPage shoppingCartPage = new ShoppingCartPage();

        public ShoppingCartSteps()
        {
            PageFactory.InitElements(driver, shoppingCartPage);
        }

        [When(@"I click '(.*)' button on Shopping Cart page")]
        public void WhenIClickButtonOnShoppingCartPage(string btnName)
        {
            switch (btnName)
            {
                case "Proceed to checkout":
                    shoppingCartPage.ProceedToCheckoutBtn.Click();
                    break;
                case "Confirmation":
                    shoppingCartPage.ConfirmBtn.Click();
                    break;
                case "Proceed on Address step":
                    shoppingCartPage.ProceedAddressStepBtn.Click();
                    break;
                case "Proceed on Shipping step":
                    shoppingCartPage.ProceedShippingStepBtn.Click();
                    break;

                default:
                    Assert.False(
                        true, "Case undefined");
                    break;
            }
        }

        [When(@"I mark Terms of Service")]
        public void WhenIMarkTermsOfService()
        {
            shoppingCartPage.TermsOfServiceChkBx.Click();
        }

        [When(@"I seleck payment method as '(.*)'")]
        public void WhenISeleckPaymentMethodAs(string paymentMethod)
        {
            shoppingCartPage.SelectPayment(paymentMethod);
        }


        [When(@"I see '(.*)' as selected payment method")]
        public void WhenISeeAsSelectedPaymentMethod(string paymentMethod)
        {
            Assert.Equal(Dictionary.EngDictionary[paymentMethod], shoppingCartPage.PaymentMethodTitle.Text);
        }

        [Then(@"I can see order confirmation message")]
        public void ThenICanSeeOrderConfirmationMessage()
        {
            Assert.Equal(Dictionary.EngDictionary["Order confirmation"], shoppingCartPage.PaymentConfirmationMsg.Text);
        }
    }
}
