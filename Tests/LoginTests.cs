using OrangeHRM.Base;
using OrangeHRM.Utilities;
using OrangeHRM.PageObjects;
using OrangeHRM.Models;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        [AllureSuite("Login")]
        [AllureSubSuite("Smoke")]
        [AllureSeverity(SeverityLevel.critical)]
        public void Login()
        {
            User currentUser = UserManager.GetCurrentUser();
            var homePage = new HomePage();

            var loginPage = homePage.Login(currentUser);

        }

    }
}
