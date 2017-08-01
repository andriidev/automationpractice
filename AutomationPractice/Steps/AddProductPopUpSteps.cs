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
    class AddProductPopUpSteps
    {
        private Driver driver = new Driver();
        private AddProductPopUpPage addProductPopUpPage = new AddProductPopUpPage();
       
        public AddProductPopUpSteps()
        {
            PageFactory.InitElements(driver, addProductPopUpPage);
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

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }
    }
}
