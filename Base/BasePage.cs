using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OrangeHRM.Base
{
    public class BasePage
    {
        protected readonly IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }
        #region Click Actions
        protected void Click(By locator)
        {
            WaitHelper.WaitForElementClickable(Driver, locator).Click();
        }
        protected void JavaScriptClick(By locator)
        {
            IWebElement element = WaitHelper.WaitForElementVisible(Driver, locator);

            ((IJavaScriptExecutor)Driver)
                .ExecuteScript("arguments[0].click();", element);
        }
        #endregion

        #region Text Actions
        protected void EnterText(By locator, string text)
        {
            IWebElement element = WaitHelper.WaitForElementVisible(Driver, locator);

            element.Clear();
            element.SendKeys(text);
        }
        protected void AppendText(By locator, string text)
        {
            IWebElement element = WaitHelper.WaitForElementVisible(Driver, locator);

            element.SendKeys(text);
        }
        protected string GetText(By locator)
        {
            return WaitHelper.WaitForElementVisible(Driver, locator).Text;
        }      
        #endregion

        #region Validation
        protected bool IsDisplayed(By locator)
        {
            return WaitHelper.WaitForElementVisible(Driver, locator).Displayed;
        }
        #endregion

        #region DropDown Actions
        protected void SelectDropdownByText(By locator, string text)
        {
            SelectElement dropdown =
                new SelectElement(
                    WaitHelper.WaitForElementVisible(Driver, locator));

            dropdown.SelectByText(text);
        }
        protected void SelectDropdownByIndex(By locator, int index)
        {
            SelectElement dropdown =
                new SelectElement(
                    WaitHelper.WaitForElementVisible(Driver, locator));

            dropdown.SelectByIndex(index);
        }
        #endregion

        #region Scroll Actions
        protected void ScrollIntoView(By locator)
        {
            IWebElement element = WaitHelper.WaitForElementVisible(Driver, locator);

            ((IJavaScriptExecutor)Driver)
                .ExecuteScript("arguments[0].scrollIntoView({behavior:'smooth', block:'center'});", element);
        }

        #endregion


    }
}
