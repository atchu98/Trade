using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Pages;
using TestAutomation.TestData;
using NUnit.Framework;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class ForexStepDefinitions
    {

        private IWebDriver _driver;
        private ForexPage _forexPage;
        private LandingPage _landingPage;
        private WebDriverWait _wait;

        LandingPageTestData landingeData = new LandingPageTestData();
        ForexTestData forexData = new ForexTestData(); 



        public ForexStepDefinitions(IWebDriver driver)
        {
            this._driver = driver;
            this._forexPage = new ForexPage(driver);
            this._landingPage = new Pages.LandingPage(driver);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
        }

        [Given(@"I launch my browser and go to the Forex Page")]
        public void GivenILaunchMyBrowserAndGoToTheForexPage()
        {
            _landingPage.NavigateToURL(_driver);
        }

        [Given(@"The cookies are accepted")]
        public void GivenTheCookiesAreAccepted()
        {
            _landingPage.CheckCoockiesAppearAndClickConfirm(_driver);
            Thread.Sleep(2000);
        }

        [When(@"I click on the Trade Nations logo")]
        public void WhenIClickOnTheTradeNationsLogo()
        {
            _forexPage.FindLogo(_driver).Click();
            Thread.Sleep(5000);
        }

        [Then(@"I should see the Title")]
        public void ThenIShouldSeeTheTitle()
        {
            string pageTitle = _landingPage.GetPageTitle(_driver);
            Assert.AreEqual(forexData.forexpageTitle, pageTitle);
        }
    }
}
