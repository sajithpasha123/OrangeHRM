using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Utilities
{
    public static class DriverManager
    {
        public static IWebDriver Driver { get; private set; }

        public static void InitializeDriver()
        {
            switch (ConfigReader.Browser.ToLower())
            {
                case "chrome":
                    Driver = new ChromeDriver();
                    break;

                default:
                    throw new Exception($"Browser '{ConfigReader.Browser}' is not supported.");
            }

            Driver.Manage().Window.Maximize();
            Driver.Navigate().GoToUrl(ConfigReader.BaseUrl);
            WaitHelper.WaitForElementVisible(Driver, By.Name("username"), 60);
        }

        public static void QuitDriver()
        {
            Driver?.Quit();
            Driver?.Dispose();
        }
    }
}
