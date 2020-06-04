Feature: Create product
    As a user 
    I want to open the application
So I want to create the new product 

Scenario: Login and create

Given I open "http://localhost:5000/Account/Login" url 
When  I enter login and password "user" 
And I click on submit button 
Then visible text should be "Home page"
When click on button: All products 
And click on button: Create new   
When adding data: ProductName(cthulhu soup),CategoryId(Seafood),SupplierId(Refrescos Americanas LTDA),UnitPrice(1),QuantityPerUnit(1),UnitsInStock(1),UnitsOnOrder(1),ReorderLevel(2)
And click on create button
Then "ctulhu soap" should be visible in all products page
End