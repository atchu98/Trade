using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomation.TestData;

namespace TestAutomation.Pages
{
    public  class ForexPage
    {
        private IWebDriver _driver;

        public ForexPage(IWebDriver driver) 
        {
            this._driver = driver;
        }

        ForexTestData forexData = new ForexTestData();
        public IWebElement FindLogo(IWebDriver driver)
        {
            return driver.FindElement(By.ClassName(forexData.tradenationLogo));
        }
        

        
    }
}
