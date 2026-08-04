using OrangeHRM.PageObjects;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Base
{
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
