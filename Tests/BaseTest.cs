using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

namespace SeleniumCore.Tests
{

    [TestFixture]
    public class BaseTest
    {
        protected IWebDriver Driver;
        [SetUp]
            protected void SetUp()
            { 
                    Driver = new FirefoxDriver();
                    Driver.Manage().Window.Maximize();
        }

            [TearDown]
            protected void TearDown()
            {
                Driver.Quit();
            }
        }
}
