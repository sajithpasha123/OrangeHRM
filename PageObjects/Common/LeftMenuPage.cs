using OpenQA.Selenium;
using OrangeHRM.Base;
using OrangeHRM.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects.Common
{
    public class LeftMenuPage : BasePage
    {
        #region Locators
        private const string MenuOptionXPath = "//span[normalize-space()='{0}']";       
        #endregion
        public LeftMenuPage(IWebDriver driver) : base(driver)
        {
        }
        public void NavigateTo(LeftMenuItem menuItem)
        {         
            Click(GetMenuOptionLocator(menuItem));
        }
        private By GetMenuOptionLocator(LeftMenuItem menuItem)
        {
            return By.XPath(string.Format(MenuOptionXPath, menuItem));
        }
        public bool IsMenuDisplayed(LeftMenuItem menuItem)
        {
            return IsDisplayed(GetMenuOptionLocator(menuItem));
        }
    }
}
