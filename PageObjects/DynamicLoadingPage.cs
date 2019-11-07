using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
    public class DynamicLoadingPage
    {
        IWebDriver Driver;
        By StartButton = By.CssSelector("#start > button");
        By FinishText = By.Id("finish");

        public DynamicLoadingPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoadExample(int exampleNumber)
        {
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/dynamic_loading/" + exampleNumber);
            Driver.FindElement(StartButton).Click();
        }

        public bool FinishTextPresent()
        {
            return WaitForIsDisplayed(FinishText, 10);
        }
        private bool WaitForIsDisplayed(By locator, int maxWaitTime)
        {
            try
            {
                WebDriverWait Wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(maxWaitTime));
                Wait.Until(ExpectedConditions.ElementIsVisible(locator));
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
