
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;
using Test_Northwind.business_object;
using Test_Northwind.page_object;

namespace Test_Northwind.step_definition
{

    [Binding]
    class StepLogin
    {
        protected Main main;
        protected FindProducts findProducts;
        protected CheckText checkText;
        protected Login input = new Login("user", "cthulhu soup");
        private IWebDriver driver;


        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string url)
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--no-sandbox");
            driver = new ChromeDriver(options);

            driver.Manage().Window.Maximize();
            driver.Url = url;

        }

        [When(@"I enter login and password ""(.*)""")]
        public void WhenIEnterLoginAndPassword(string LoginPassword)
        {
            new Main(driver).Entry(new Login(LoginPassword, null));
        }


        [When(@"I click on submit button")]
        public void WhenIClickOnSubmitButton()
        {
            new Main(driver).ClickEntry();
        }

        [Then(@"visible text should be ""(.*)""")]

        public void ThenVisibleTextSholdBe(string setText)
        {
            Assert.AreEqual(setText, new CheckText(driver).CheckTextExp());
        }

        [When(@"click on button: All products")]
        public void WhenClickOnAllProductsButton()
        {
            main.AllProductsClick();
        }

        [When(@"click on button: Create new")]
        public void WhenClickOnCreateNewButton()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
        }

       

        [When(@"adding data: ProductName(cthulhu soup),CategoryId(Seafood),SupplierId(Refrescos Americanas LTDA),UnitPrice(1),QuantityPerUnit(1),UnitsInStock(1),UnitsOnOrder(1),ReorderLevel(2)")]
        public void WhenAddingOtherData()
        {
            main.EntryData();
        }

        [When(@"click on create button")]
        public void WhenClickOnCreateButton()
        {
            main.SubmitButton();
        }


        [Then(@"""(.*)"" should be visible in all products page")]
        public void ThenVisibleTextIs(string setTextAfterCreate)
        {
            Assert.AreEqual(setTextAfterCreate, findProducts.FinishedProduct());
            
        }



    }
}
