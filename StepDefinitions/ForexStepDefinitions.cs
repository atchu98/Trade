using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TestAutomation.Pages;
using TestAutomation.TestData;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class ForexStepDefinitions
    {

        private IWebDriver _driver;
        private LoginPage _loginPage;
        private LandingPage _landingPage;
        private WebDriverWait _wait;

        LandingPageTestData searchPageData = new TestData.LandingPageTestData();



        public ForexStepDefinitions(IWebDriver driver)
        {
            this._driver = driver;
            this._loginPage = new LoginPage(driver);
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
            throw new PendingStepException();
        }

        [When(@"I click on the Trade Nations logo")]
        public void WhenIClickOnTheTradeNationsLogo()
        {
            throw new PendingStepException();
        }

        [Then(@"I should see the Title")]
        public void ThenIShouldSeeTheTitle()
        {
            throw new PendingStepException();
        }
    }
}
