using AutomationPractice.PageObjects;
using AutomationPractice.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    class CommonSteps
    {
        private Driver driver = new Driver();
        private MainPage mainPage = new MainPage();
        private AuthenticationPage authenticationPage = new AuthenticationPage();
        private RegistrationPage registrationPage = new RegistrationPage();

        public CommonSteps()
        {
            PageFactory.InitElements(driver, mainPage);
            PageFactory.InitElements(driver, authenticationPage);
            PageFactory.InitElements(driver, registrationPage);
        }

        public static string userEmail = null;
        public static string userPassword = null;

        [BeforeScenario("login")]
        public void BeforeScenarioLogIn()
        {
            GivenINavigateToPage("home");
            mainPage.SignIn.Click();
            if (userEmail == null)
            {
                userEmail = "newUser@mailinator.com";
            }
            if (userPassword == null)
            {
                userPassword = "password";
            }
            authenticationPage.SignIn(userEmail, userPassword);
        }

        [AfterScenario("logout")]
        public void AfterscenarioLogout()
        {
            mainPage.LogoutBouttnClick();
        }

        [Given(@"I navigate to '(.*)' page")]
            public void GivenINavigateToPage(string pageName)
        {
            switch (pageName.ToLower())
            {
                case "home":
                    driver.Navigate().GoToUrl(Properties.Settings.Default.url);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [Given(@"Click '(.*)' button")]
        public void GivenClickButton(string button)
        {
            mainPage.SignIn.Click();
        }

        [Given(@"I can see '(.*)' label")]
        public void GivenICanSeeLabel(string label)
        {
            switch (label.ToLower())
            {
                case "authentication":
                    Assert.Equal(Dictionary.EngDictionary["Authentication"], authenticationPage.AuthenticationLabel.Text);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;

            }
        }

        [Then(@"I can see users credentials on View my account button")]
        public void ThenICanSeeUsersCredentialsOnViewMyAccountButton()
        {
            Assert.Equal(RegistrationSteps.userName, mainPage.ViewMyAccount.Text);
        }

        [Given(@"I switch to Best sellers tab")]
        public void GivenISwitchToBestSellersTab()
        {
            mainPage.BestSellersButton.Click();
        }

        [When(@"I hower on product with discount in the list")]
        public void WhenIHowerOnProductWithDiscountInTheList()
        {
            driver.HoverOnElement(mainPage.ItemImage);
        }

        [When(@"I click '(.*)' button on product card")]
        public void WhenIClickButtonOnProductCard(string btnName)
        {
            switch (btnName.ToLower())
            {
                case "add to cart":
                    mainPage.AddToCartBtn.Click();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }
    }
}
