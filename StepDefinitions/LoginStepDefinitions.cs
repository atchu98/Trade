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
        LandingPageTestData landingData = new TestData.LandingPageTestData();



        public LoginStepDefinitions(IWebDriver driver, LoginPage loginPage, Pages.LandingPage searchPage)
        {
            this._driver = driver;
            this._loginPage = new LoginPage(driver);
            this._landingPage = new Pages.LandingPage(driver);
            _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(100));
        }

        [Given(@"I launch my browser and go to Landing Page")]
        public void GivenILaunchMyBrowserAndGoToLandingPage()
        {
            _landingPage.NavigateToURL(_driver, landingData.landingPage);
            Thread.Sleep(2000);
        }

        [Given(@"I click login / Signup")]
        public void GivenIClickLoginSignup()
        {
            _landingPage.LocateSignupButton(_driver).Click();
            Thread.Sleep(2000);
        }

        [When(@"I Enter the Incorrect Email in Signup")]
        public void WhenIEnterTheIncorrectEmailInSignup()
        {
            _loginPage.FindAndEnterEmailAddress(_driver, loginData.incorrectEmail);
        }

        [Then(@"I get the Email Address Error")]
        public void ThenIGetTheEmailAddressError()
        {
            var error = _loginPage.FindEmailError(_driver).Text;
            Assert.AreEqual(loginData.emailErrorMessage,error);
        }

        [When(@"I Enter the  Email in Signup")]
        public void WhenIEnterTheEmailInSignup()
        {
            _loginPage.FindAndEnterEmailAddress(_driver, loginData.validEmail);

        }

        [When(@"I enter Invalid password")]
        public void WhenIEnterInvalidPassword()
        {
            _loginPage.FindAndEnterPassword(_driver, loginData.invalidPassword);
        }

        [Then(@"I get the Password Error")]
        public void ThenIGetThePasswordError()
        {
            var error1 = _loginPage.FindPaswwordError(_driver)[0].Text;
            var error2 = _loginPage.FindPaswwordError(_driver)[1].Text;
            var error3 = _loginPage.FindPaswwordError(_driver)[2].Text;

            Assert.AreEqual(loginData.error1,error1);
            Assert.AreEqual(loginData.error2, error2);
            Assert.AreEqual(loginData.error3, error3);




        }


    }
}
