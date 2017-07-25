using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace AutomationPractice.PageObjects
{
    class MainPage
    {
        [FindsBy(How = How.CssSelector, Using = ".logo.img-responsive")]
        public IWebElement ActiveTableHeader { get; set; }
        [FindsBy(How = How.CssSelector, Using = ".login")]
        public IWebElement SignIn { get; set; }
        

        //Actions
    }
}
