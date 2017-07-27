using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    class AuthenticationPage
    {
        [FindsBy(How = How.CssSelector, Using = ".page-heading")]
        public IWebElement AuthenticationLabel { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#email_create")]
        public IWebElement NewEmailInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#SubmitCreate")]
        public IWebElement CreateAnAccountButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement EmailInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        public IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#SubmitLogin")]
        public IWebElement SignInButton { get; set; }

        //Actions
        public void NewEmailSendNewKeys(string value)
        {
            NewEmailInput.Clear();
            NewEmailInput.SendKeys(value);
        }
        public void EmailInputSendNewKeys(string value)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(value);
        }
        public void PasswordSendNewKeys(string value)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(value);
        }
        public void CreateAccountClick()
        {
            CreateAnAccountButton.Click();
        }
        public void SignInClick()
        {
            SignInButton.Click();
        }
    }
}
