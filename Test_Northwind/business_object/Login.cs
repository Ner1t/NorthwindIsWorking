using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Northwind.business_object
{
    public class Login
    {
        public string InputLoginPassword { get; set; }

        public string ProductName { get; set; }

        public Login(string InputLogin, string ProductName)
        {
            this.InputLoginPassword = InputLogin;
            
            this.ProductName = ProductName;
        }



    }
}
