﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeleniumCore.PageObjects
{
  public class LoginPage
    {
        IWebDriver Driver;
        By UsernameInput = By.Id("username");
        By PasswordInput = By.Id("password");
        By SubmitButton = By.CssSelector("button");
        By SuccessMessage = By.CssSelector(".flash.success");
        By FailureMessage = By.CssSelector(".flash.error");

        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
            Driver.Navigate().GoToUrl("http://the-internet.herokuapp.com/login");
        }

        public void With(string username, string password)
        {
            Driver.FindElement(UsernameInput).SendKeys(username);
            Driver.FindElement(PasswordInput).SendKeys(password);
            Driver.FindElement(SubmitButton).Click();
        }

        public bool SuccessMessagePresent()
        {
            return Driver.FindElement(SuccessMessage).Displayed;
        }

        public bool FailureMessagePresent()
        {
            return Driver.FindElement(FailureMessage).Displayed;
        }

    }
}
