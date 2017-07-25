using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using System.Drawing;

namespace AutomationPractice.Utilities
{
    class Driver : IWebDriver
    {
        public string Url { get; set; }

        public string Title => throw new NotImplementedException();

        public string PageSource => throw new NotImplementedException();

        public string CurrentWindowHandle => throw new NotImplementedException();

        public ReadOnlyCollection<string> WindowHandles => throw new NotImplementedException();
        

        private static IWebDriver driver;
        private static WebDriverWait wait;
        private static IJavaScriptExecutor jsExecutor;

        public Driver()
        {
            driver = Initialize();
        }

        private static IWebDriver Initialize()
        {
            var driver = new ChromeDriver();
            driver.Manage().Window.Size = new Size(1024, 768);
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
            jsExecutor = driver as IJavaScriptExecutor;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));


            return driver;
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            throw new NotImplementedException();
        }

        public IOptions Manage()
        {
            throw new NotImplementedException();
        }

        public INavigation Navigate()
        {
            return driver.Navigate();
        }

        public void Quit()
        {
            driver.Quit();
        }

        public ITargetLocator SwitchTo()
        {
            throw new NotImplementedException();
        }
    }
}
