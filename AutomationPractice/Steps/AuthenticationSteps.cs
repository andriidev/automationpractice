using AutomationPractice.PageObjects;
using AutomationPractice.Utilities;
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
    class AuthenticationSteps
    {
        private Driver driver = new Driver();
        private AuthenticationPage authenticationPage = new AuthenticationPage();

        public AuthenticationSteps()
        {
            PageFactory.InitElements(driver, authenticationPage);
        }

        [When(@"I type '(.*)' email")]
        public void WhenITypeEmail(string email)
        {
            switch (email.ToLower())
            {
                case "new user":
                    authenticationPage.NewEmailSendNewKeys(DataGeneator.DateTimeBasedString() + "@" + Properties.Settings.Default.emailDomain);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }

            
        }

        [When(@"I click '(.*)' button on authantication page")]
        public void WhenIClickButtonOnAuthanticationPage(string button)
        {
            switch (button.ToLower())
            {
                case "create an account":
                    authenticationPage.CreateAccountClick();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

    }
}
