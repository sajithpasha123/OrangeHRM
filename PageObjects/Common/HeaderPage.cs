using OpenQA.Selenium;
using OrangeHRM.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects.Common
{
    public class HeaderPage : BasePage
    {
        #region Locators
        private readonly By profileMenu =
            By.XPath("//span[@class='oxd-userdropdown-tab']");

        private readonly By logoutMenu =
            By.XPath("//a[normalize-space()='Logout']");
        #endregion

        public HeaderPage(IWebDriver driver) : base(driver)
        {
        }

        #region LogOut
        public LoginPage Logout()
        {
            Click(profileMenu);
            Click(logoutMenu);

            return new LoginPage(Driver);
        }
        #endregion


    }
}
