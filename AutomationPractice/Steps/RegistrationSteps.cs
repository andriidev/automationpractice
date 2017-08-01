using AutomationPractice.Entities;
using AutomationPractice.PageObjects;
using AutomationPractice.Utilities;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using Xunit;

namespace AutomationPractice.Steps
{
    [Binding]
    class RegistrationSteps
    {
        private Driver driver = new Driver();
        private RegistrationPage registrationPage = new RegistrationPage();

        public RegistrationSteps()
        {
            PageFactory.InitElements(driver, registrationPage);
        }

        public static string userName;

        [When(@"I fill following fields in '(.*)' area")]
        public void WhenIFillFollowingFieldsInArea(string area, Table table)
        {
            switch (area)
            {
                case "YOUR PERSONAL INFORMATION":
                    var item = table.CreateInstance<YourPersonalInformation>();
                    userName = item.FirstName + " " + item.LastName;
                    CommonSteps.userPassword = item.Password;
                    registrationPage.fillPersonalInfo(item);
                    break;

                case "YOUR ADDRESS":
                    var item2 = table.CreateInstance<YourAddress>();
                    registrationPage.fillAddress(item2);
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        [When(@"I click '(.*)' button")]
        public void WhenIClickButton(string p0)
        {
            registrationPage.RegisterButton.Click();
        }

    }
}
