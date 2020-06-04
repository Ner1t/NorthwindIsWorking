using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Northwind.tests
{
    public class Base
    {
        protected IWebDriver driver;


        [SetUp]
        public void Setup()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            driver = new ChromeDriver(options);

            driver.Navigate().GoToUrl("http://localhost:5000/Account/Login?ReturnUrl=%2F");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);


        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
            driver.Quit();
        }
    }
}