using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Base
{
    public class BaseTest
    {
        [SetUp]
        public void SetUp()
        {
            DriverManager.InitializeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            DriverManager.QuitDriver();
        }
    }
}
