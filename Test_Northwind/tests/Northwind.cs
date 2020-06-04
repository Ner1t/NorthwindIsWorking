using NUnit.Framework;
using OpenQA.Selenium;
using Test_Northwind.business_object;
using Test_Northwind.page_object;
using Test_Northwind.tests;

namespace Test_Northwind
{
    //public class Tests : Base
    //{

    //    protected Main main;
    //    protected FindProducts findProducts;
    //    protected CheckText checkText;
    //    protected Login input = new Login("user","cthulhu soup");
    //    [Test]
    //    public void LoginAndCreate()
    //    {
    //        main = new Main(driver);
    //        main.Entry(input);
    //        main.ClickEntry();
    //        Assert.AreEqual("Home page", checkText.CheckTextExp());
    //        main.AllProductsClick();
    //        driver.FindElement(By.XPath("//a[contains(text(),'Create new')]")).Click();
    //        findProducts.Product(input);
    //        driver.FindElement(By.XPath("//select[@name ='CategoryId']")).Click();
    //        driver.FindElement(By.XPath("//*/option[text() ='Seafood']")).Click();
    //        driver.FindElement(By.XPath("//select[@name ='SupplierId']")).Click();
    //        driver.FindElement(By.XPath("//*/option[text() ='Refrescos Americanas LTDA']")).Click();
    //        driver.FindElement(By.XPath("//input[@id='UnitPrice']")).SendKeys("1928");
    //        driver.FindElement(By.XPath("//input[@id='QuantityPerUnit']")).SendKeys("1");
    //        driver.FindElement(By.XPath("//input[@id='UnitsInStock']")).SendKeys("1");
    //        driver.FindElement(By.XPath("//input[@id='UnitsOnOrder']")).SendKeys("1");
    //        driver.FindElement(By.XPath("//input[@id='ReorderLevel']")).SendKeys("0");
    //        driver.FindElement(By.XPath("//input[@type='submit']")).Click();
    //        var CreateIsOkay = driver.FindElement(By.XPath("//*/h2[text() = 'All Products']"));
    //        Assert.AreEqual("All Products", CreateIsOkay.Text);

    //    }
    //    [Test]
    //    public void Verification()
    //    {

    //        main = new Main(driver);
    //        findProducts = new FindProducts(driver);
    //        main.Entry(input);
    //        main.ClickEntry();
    //        main.AllProductsClick();

    //        findProducts.Product(input);

    //        var CategoryId = driver.FindElement(By.XPath("// div/*[@id = 'CategoryId'] / option[@value ='8']"));
    //        Assert.AreEqual("Seafood", CategoryId.Text);

    //        var SupplierId = driver.FindElement(By.XPath("// div/*[@id = 'SupplierId'] / option[@value ='10']"));
    //        Assert.AreEqual("Refrescos Americanas LTDA", SupplierId.Text);

    //        var priceElement = driver.FindElement(By.XPath("//input[@id='Discontinued']"));
    //        Assert.IsFalse(priceElement.Selected);

    //    }
    //    [Test]
    //    public void Logout()
    //    {
    //        main = new Main(driver);
    //        main.Entry(input);
    //        main.ClickEntry();
    //        driver.FindElement(By.XPath("//a[contains(text(),'Logout')]")).Click();
    //        var Login = driver.FindElement(By.XPath("//h2"));
    //        Assert.AreEqual("Login", Login.Text);

    //    }


    //}
}