using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.TestData;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;

namespace TestAutomation.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;
        LoginTestData loginData = new LoginTestData(); 
        private WebDriverWait wait;

        public LoginPage(IWebDriver driver)
        {
            this._driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(200));
        }

      

    }
}
