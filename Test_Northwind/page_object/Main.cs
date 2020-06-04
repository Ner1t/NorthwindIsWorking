using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Test_Northwind.business_object;

namespace Test_Northwind.page_object
{
    public class Main
    {

        private IWebDriver driver;


        public Main(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement SearchInputLogin => driver.FindElement(By.XPath("//div[1]/div/input"));
        private IWebElement SearchInputPassword => driver.FindElement(By.XPath("//div[2]/div/input"));
        public IWebElement ClickAllProducts => driver.FindElement(By.XPath("//a[contains(text(),'All Products')]"));
        public IWebElement ClickSubmit => driver.FindElement(By.XPath("//*[@type= 'submit']"));


        public IWebElement ProductName => driver.FindElement(By.XPath("//input[@id='ProductName']"));
        public IWebElement CategoryId => driver.FindElement(By.XPath("//select[@name ='CategoryId']"));
        public IWebElement Seafood => driver.FindElement(By.XPath("//*/option[text() ='Seafood']"));
        public IWebElement SupplierId => driver.FindElement(By.XPath("//select[@name ='SupplierId']"));
        public IWebElement Refrescos => driver.FindElement(By.XPath("//*/option[text() ='Refrescos Americanas LTDA']"));
        public IWebElement UnitPrice => driver.FindElement(By.XPath("//input[@id='UnitPrice']"));
        public IWebElement QuantityPerUnit => driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']"));
        public IWebElement UnitsInStock => driver.FindElement(By.XPath("//input[@id='UnitsInStock']"));
        public IWebElement UnitsOnOrder => driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']"));
        public IWebElement ReorderLevel => driver.FindElement(By.XPath("//input[@id='ReorderLevel']"));

        public IWebElement submit => driver.FindElement(By.XPath("//input[@type='submit']"));

        public Main Entry(Login loginText)
        {
            new Actions(driver).Click(SearchInputLogin).SendKeys(loginText.InputLoginPassword).Click(SearchInputPassword).SendKeys(loginText.InputLoginPassword).Build().Perform();

            return this;

        }

        public void EntryData()
        {
            new Actions(driver).Click(ProductName).SendKeys("cthulhu soup").Click(CategoryId).Click(Seafood).Click(SupplierId).Click(Refrescos).Click(UnitPrice).SendKeys("1928").Click(QuantityPerUnit).SendKeys("1").Click(UnitsInStock).SendKeys("1").Click(UnitsOnOrder).SendKeys("1").Click(ReorderLevel).SendKeys("0").Build().Perform();
            
        }

        public void SubmitButton()
        {
            new Actions(driver).Click(submit).Build().Perform();
        }


        public void ClickEntry()
        {
            new Actions(driver).Click(ClickSubmit).Build().Perform();

        }
        public void AllProductsClick()
        {
            new Actions(driver).Click(ClickAllProducts).Build().Perform();
        }

    }
}
