using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.Utilities
{
    public static class WaitHelper
    {
        /// <summary>
        /// Wait until element is visible
        /// </summary>
        public static IWebElement WaitForElementVisible(IWebDriver driver, By locator, int timeoutInSeconds = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));

            return wait.Until(d =>
            {
                try
                {
                    var element = d.FindElement(locator);
                    return element.Displayed ? element : null;
                }
                catch (NoSuchElementException)
                {
                    return null;
                }
            });
        }
        /// <summary>
        /// Wait until element is clickable
        /// </summary>
        public static IWebElement WaitForElementClickable(IWebDriver driver, By locator, int timeout = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            return wait.Until(d =>
            {
                try
                {
                    IWebElement element = d.FindElement(locator);

                    return (element.Displayed && element.Enabled)
                        ? element
                        : null;
                }
                catch
                {
                    return null;
                }
            });
        }
        /// <summary>
        /// Wait until element disappears
        /// </summary>
        public static bool WaitForElementInvisible(IWebDriver driver, By locator, int timeout = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            return wait.Until(d =>
            {
                try
                {
                    return !d.FindElement(locator).Displayed;
                }
                catch
                {
                    return true;
                }
            });
        }

        /// <summary>
        /// Wait until page is completely loaded
        /// </summary>
        public static void WaitForPageLoad(IWebDriver driver, int timeout = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until(d =>
            {
                var readyState = ((IJavaScriptExecutor)d)
                    .ExecuteScript("return document.readyState")?.ToString();

                return readyState == "complete";
            });
        }

        /// <summary>
        /// Wait until page title contains text
        /// </summary>
        public static void WaitForTitle(IWebDriver driver, string title, int timeout = 60)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));

            wait.Until(d => d.Title.Contains(title));
        }
    }
}
