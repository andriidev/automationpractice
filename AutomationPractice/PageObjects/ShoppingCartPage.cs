using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace AutomationPractice.PageObjects
{
    class ShoppingCartPage
    {
        //Elements
        [FindsBy(How = How.CssSelector, Using = ".button.btn.btn-default.standard-checkout.button-medium>span")]
        public IWebElement ProceedToCheckoutBtn { get; set; }
        [FindsBy(How = How.Name, Using = "processAddress")]
        public IWebElement ProceedAddressStepBtn { get; set; }
        [FindsBy(How = How.Name, Using = "processCarrier")]
        public IWebElement ProceedShippingStepBtn { get; set; }
        [FindsBy(How = How.XPath, Using = ".//*[@id='cart_navigation']/button")]
        public IWebElement ConfirmBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#cgv")]
        public IWebElement TermsOfServiceChkBx { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".bankwire")]
        public IWebElement PayByBankWireBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".cheque")]
        public IWebElement PayByCheckBtn { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".page-subheading")]
        public IWebElement PaymentMethodTitle { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".cheque-indent > strong")]
        public IWebElement PaymentConfirmationMsg { get; set; }
        

        //Actions
        public void PayByBankWireClick()
        {
            PayByBankWireBtn.Click();
        }
        public void PayByCheckClick()
        {
            PayByCheckBtn.Click();
        }
        public void SelectPayment(string paymentMethod)
        {
            switch (paymentMethod.ToLower())
            {
                case "bank card":
                    PayByBankWireClick();
                    break;
                case "check":
                    PayByCheckClick();
                    break;

                default:
                    Assert.False(
                        true, "Case undefined");
                    break;
            }
        }
    }
}
