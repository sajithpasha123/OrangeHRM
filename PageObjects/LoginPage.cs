using OpenQA.Selenium;
using OrangeHRM.Base;
using OrangeHRM.Utilities;
using OrangeHRM.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    public class LoginPage : BasePage
    {
        private readonly By txtUsername = By.Name("username");
        private readonly By txtPassword = By.Name("password");
        private readonly By btnLogin = By.XPath("//button[@type='submit']");

        public LoginPage(IWebDriver driver) : base(driver)
        {
            WaitHelper.WaitForElementVisible(driver, txtUsername, 60);
        }

        public void Login(User user)
        {
            EnterText(txtUsername, user.UserName);
            EnterText(txtPassword, user.Password);
            Click(btnLogin);
        }

    }
}
