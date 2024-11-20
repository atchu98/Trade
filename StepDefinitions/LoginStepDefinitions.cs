using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using TestAutomation.TestData;
using TestAutomation.Pages;
using FluentAssertions.Execution;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.WaitHelpers;

namespace TestAutomation.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        private IWebDriver _driver;
        private LoginPage _loginPage;
        private LandingPage _landingPage;
        private WebDriverWait _wait;

        LoginTestData loginData = new LoginTestData();
        LandingPageTestData searchPageData = new TestData.LandingPageTestData();



        public LoginStepDefinitions(IWebDriver driver, LoginPage loginPage, Pages.LandingPage searchPage)
        {
            this._driver = driver;
            this._loginPage = new LoginPage(driver);
            this._landingPage = new Pages.LandingPage(driver);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
        }

   

    }
}
