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
        [FindsBy(How = How.CssSelector, Using = ".login")]
        public IWebElement Authentication { get; set; }


    }
}
