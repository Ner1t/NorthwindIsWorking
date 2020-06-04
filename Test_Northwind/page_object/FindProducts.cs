using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using Test_Northwind.business_object;

namespace Test_Northwind.page_object
{
    public class FindProducts
    {

        private IWebDriver driver;

        public FindProducts(IWebDriver driver)
        {
            this.driver = driver;
        }
        

        public void Product(Login product)
        {
            driver.FindElement(By.XPath($"//a[contains(text(), \"{product.ProductName}\" )]")).Click();

        }

        public FindProducts FinishedProduct()
        {
                    driver.FindElement(By.XPath($"//a[contains(text(),'cthulhu soup')]"));
            return this;
        }
    }
    
}
