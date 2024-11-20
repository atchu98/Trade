using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.TestData;

namespace TestAutomation.Pages
{
    public class LandingPage
    {
        private IWebDriver _driver;
        LandingPageTestData lPData = new LandingPageTestData();
        ForexTestData ftData = new ForexTestData();
        public LandingPage(IWebDriver driver) 
        {
            this._driver = driver;
        }

        public LandingPage NavigateToURL(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            return this;
        }

        public LandingPage CheckCoockiesAppearAndClickConfirm(IWebDriver driver)
        {
            Thread.Sleep(5000);
            if(driver.FindElement(By.Id(lPData.cookiesacceptbuttonID)).Displayed)
            {
                driver.FindElement(By.Id(lPData.cookiesacceptbuttonID)).Click();
            }
            

            return this;
        }

        public string  GetPageTitle(IWebDriver driver)
        {
            return driver.Title;

        }

        public IWebElement LocateSignupButton(IWebDriver driver)
        {
            return driver.FindElement(By.LinkText("Sign up / Log in"));
        }

    }
}
