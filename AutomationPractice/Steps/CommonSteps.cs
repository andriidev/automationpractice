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
    class CommonSteps
    {
        private Driver driver = new Driver();
        private MainPage mainPage = new MainPage();

        public CommonSteps()
        {
            PageFactory.InitElements(driver, mainPage);
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


    }
}
