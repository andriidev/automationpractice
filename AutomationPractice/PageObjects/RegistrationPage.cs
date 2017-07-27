using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationPractice.PageObjects
{
    class RegistrationPage
    {
        //Your personal information
        [FindsBy(How = How.CssSelector, Using = "#id_gender1")]
        public IWebElement GenderMrRadioButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#id_gender2")]
        public IWebElement GenderMrsRadioButton { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#customer_firstname")]
        public IWebElement CustomerFirstNameInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#customer_lastname")]
        public IWebElement CustomerLastNameInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#email")]
        public IWebElement EmailInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#passwd")]
        public IWebElement PasswordInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#days")]
        public IWebElement DateOfBirthDayDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#months")]
        public IWebElement DateOfBirthMonthDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#years")]
        public IWebElement DateOfBirthYearhDDL { get; set; }
        //Your address
        [FindsBy(How = How.CssSelector, Using = "#firstname")]
        public IWebElement FirstNameInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#lastname")]
        public IWebElement LastNameInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#lastname")]
        public IWebElement CompanyInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#address1")]
        public IWebElement AddressInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#address2")]
        public IWebElement Addres2Input { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#city")]
        public IWebElement CityInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#id_state")]
        public IWebElement StateDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#postcode")]
        public IWebElement ZipInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#id_country")]
        public IWebElement CountryDDL { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#other")]
        public IWebElement AdditionalInfoInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#phone")]
        public IWebElement HomePhoneInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#phone_mobile")]
        public IWebElement MobilePhoneInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#alias")]
        public IWebElement AliasInput { get; set; }
        [FindsBy(How = How.CssSelector, Using = "#submitAccount")]
        public IWebElement RegisterButton { get; set; }
    }
}
