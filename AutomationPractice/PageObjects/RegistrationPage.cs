using AutomationPractice.Entities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

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
        [FindsBy(How = How.CssSelector, Using = "#company")]
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

        //Actions
        public void fillPersonalInfo(YourPersonalInformation item)
        {
            SelectTitle(item.Title);
            CustomerFirstNameSendNewKeys(item.FirstName);
            CustomerLastNameSendNewKeys(item.LastName);
            if (item.Email != "")
            {
                EmailSendNewKeys(item.Email);
            }
            PasswordSendNewKeys(item.Password);
            SetDateOfBirth(item.DateOfBirth);
        }

        public void fillAddress(YourAddress item)
        {
            FirstNameSendNewKeys(item.FirstName);
            LastNameSendNewKeys(item.LastName);
            CompanySendNewKeys(item.Company);
            AddressSendNewKeys(item.Address);
            Address2SendNewKeys(item.Address2);
            CitySendNewKeys(item.City);
            StateSelect(item.State);
            zipSendNewKeys(item.Zip);
            CountrySelect(item.Country);
            AdditionalInfoSendNewKews(item.AdditionalInfo);
            HomePhoneSendNewKeys(item.HomePhone);
            MobilePhoneSendNewKeys(item.MobilePhone);
            AliasSendNewKeys(item.Alias);
        }

        public void SelectTitle(string title)
        {
            switch (title.ToLower())
            {
                case "mr.":
                    GenderMrRadioButton.Click();
                    break;

                case "mrs.":
                    GenderMrsRadioButton.Click();
                    break;

                default:
                    Assert.False(true, "Case undefined");
                    break;
            }
        }

        public void FirstNameSendNewKeys(string firstName)
        {
            FirstNameInput.Clear();
            FirstNameInput.SendKeys(firstName);
        }

        public void LastNameSendNewKeys(string lastName)
        {
            LastNameInput.Clear();
            LastNameInput.SendKeys(lastName);
        }

        public void EmailSendNewKeys(string email)
        {
            EmailInput.Clear();
            EmailInput.SendKeys(email);
        }

        public void PasswordSendNewKeys(string password)
        {
            PasswordInput.Clear();
            PasswordInput.SendKeys(password);
        }

        public void SetDateOfBirth(string dateOfBirth)
        {
            string[] date = dateOfBirth.Split('.');
            new SelectElement(DateOfBirthDayDDL).SelectByValue(date[0]);
            new SelectElement(DateOfBirthMonthDDL).SelectByText(date[1]);
            new SelectElement(DateOfBirthYearhDDL).SelectByValue(date[2]);

        }

        public void CustomerFirstNameSendNewKeys(string fName)
        {
            CustomerFirstNameInput.Clear();
            CustomerFirstNameInput.SendKeys(fName);
        }

        public void CustomerLastNameSendNewKeys(string lName)
        {
            CustomerLastNameInput.Clear();
            CustomerLastNameInput.SendKeys(lName);
        }

        public void CompanySendNewKeys(string company)
        {
            CompanyInput.Clear();
            CompanyInput.SendKeys(company);
        }

        public void AddressSendNewKeys(string address)
        {
            AddressInput.Clear();
            AddressInput.SendKeys(address);
        }

        public void Address2SendNewKeys(string address)
        {
            Addres2Input.Clear();
            Addres2Input.SendKeys(address);
        }

        public void CitySendNewKeys(string city)
        {
            CityInput.Clear();
            CityInput.SendKeys(city);
        }

        public void StateSelect(string state)
        {
            new SelectElement(StateDDL).SelectByText(state);
        }

        public void zipSendNewKeys(string zip)
        {
            ZipInput.Clear();
            ZipInput.SendKeys(zip);
        }

        public void CountrySelect(string country)
        {
            new SelectElement(CountryDDL).SelectByText(country);
        }

        public void AdditionalInfoSendNewKews(string addInf)
        {
            AdditionalInfoInput.Clear();
            AdditionalInfoInput.SendKeys(addInf);
        }

        public void HomePhoneSendNewKeys(string homePhone)
        {
            HomePhoneInput.Clear();
            HomePhoneInput.SendKeys(homePhone);
        }

        public void MobilePhoneSendNewKeys(string mobilePhone)
        {
            MobilePhoneInput.Clear();
            MobilePhoneInput.SendKeys(mobilePhone);
        }

        public void AliasSendNewKeys(string alias)
        {
            AliasInput.Clear();
            AliasInput.SendKeys(alias);
        }
    }
}
