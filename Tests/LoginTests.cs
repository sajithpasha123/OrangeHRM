using OrangeHRM.Base;
using OrangeHRM.Utilities;
using OrangeHRM.PageObjects;
using OrangeHRM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void Login()
        {
            User currentUser = UserManager.GetCurrentUser();

            LoginPage loginPage = new LoginPage(DriverManager.Driver);

            // Step 1: Login to OrangeHRM
            loginPage.Login(currentUser);
        }
    }
}
