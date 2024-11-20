using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.TestData;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Support.UI;
using TestAutomation.Drivers;

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

      
        public LoginPage FindAndEnterEmailAddress(IWebDriver driver, string email)
        {
            driver.FindElement(By.Id(loginData.emailID)).SendKeys(email);
            return this;
        }

        public IWebElement FindEmailError(IWebDriver driver)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            IWebElement errorMessage = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions
                .ElementIsVisible(By.CssSelector("p.MuiFormHelperText-root.Mui-error.MuiFormHelperText-sizeMedium.MuiFormHelperText-contained.css-sbpyf7")));
            return errorMessage;
            //return driver.FindElement(By.ClassName(loginData.ErrorClassName));
        }

        public IList<IWebElement> FindPaswwordError(IWebDriver driver)
        {
            IList<IWebElement> errorMessages = driver.FindElements(By.CssSelector("p.MuiFormHelperText-root.Mui-error.MuiFormHelperText-sizeMedium.MuiFormHelperText-contained.css-sbpyf7"));

            // Check if any error messages were found
            if (errorMessages.Count > 0)
            {
                Console.WriteLine("Error Messages Found:");

                // Iterate through all error elements and print their text
                foreach (IWebElement errorMessage in errorMessages)
                {
                    Console.WriteLine(errorMessage.Text);
                }
            }
            return errorMessages;
           // return driver.FindElements(By.ClassName(loginData.ErrorClassName));

        }

        public LoginPage FindAndEnterPassword(IWebDriver driver, string password)
        {
            driver.FindElement(By.Id(loginData.passwordID)).SendKeys(password);
            return this;
        }

    }
}
