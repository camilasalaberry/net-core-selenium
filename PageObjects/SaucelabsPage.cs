using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace SeleniumCore.PageObjects
{
    public class SaucelabsPage
    {
        IWebDriver Driver;
        By userName = By.Id("user-name");
        By passWord = By.Id("password");
        By loginButton = By.XPath("//*[@id='login_button_container']/div/form/input[3]");
        public SaucelabsPage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Navigate().GoToUrl("https://www.saucedemo.com");
        }

        public void With(string user, string pass)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(10)).Until(ExpectedConditions.ElementExists(loginButton));
            Driver.FindElement(userName).SendKeys(user);
            Driver.FindElement(passWord).SendKeys(pass);
            Driver.FindElement(loginButton).Click();


        }



    }
}
