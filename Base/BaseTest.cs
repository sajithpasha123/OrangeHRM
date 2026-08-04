using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using Allure.NUnit;
using Allure.NUnit.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Base
{
    [AllureNUnit]
    public class BaseTest
    {
        protected HomePage HomePage;

        [SetUp]
        public void SetUp()
        {
            DriverManager.InitializeDriver();

            HomePage = new HomePage();
        }

        [TearDown]
        public void TearDown()
        {
            try
            {
                HomePage.Logout();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logout failed: {ex.Message}");
            }
            finally
            {
                DriverManager.QuitDriver();
            }
        }
        
    }
}
