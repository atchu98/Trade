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

        public LandingPage NavigateToURL(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(ftData.forexURL);
            return this;
        }

        public LandingPage CheckCoockiesAppearAndClickConfirm(IWebDriver driver)
        {
            Thread.Sleep(5000);
            if(driver.FindElement(By.Id("onetrust-accept-btn-handler")).Displayed)
            {
                driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            }

            return this;
        }

    }
}
