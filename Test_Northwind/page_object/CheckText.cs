using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;


namespace Test_Northwind.page_object
{
    public class CheckText
    {


        private IWebDriver driver;

        public CheckText(IWebDriver driver)
        {
            this.driver = driver;
        }
        private IWebElement HomePage => driver.FindElement(By.XPath("//h2"));

        private IWebElement AllProd => driver.FindElement(By.XPath("//*/h2[text() = 'All Products']"));
        

        public string CheckTextExp()
        {
            
            return HomePage.Text;

        }
        public string CheckTextExpAfter()
        {

            return AllProd.Text;

        }
    }
}
