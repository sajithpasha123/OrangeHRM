using OrangeHRM.Models;
using OrangeHRM.PageObjects.Common;
using OrangeHRM.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeHRM.PageObjects
{
    public class HomePage
    {
        public LoginPage Login(User user)
        {
            LoginPage loginPage = new LoginPage(DriverManager.Driver);

            loginPage.Login(user);
            return loginPage;           
        }

        public LoginPage Logout()
        {
            HeaderPage headerPage = new HeaderPage(DriverManager.Driver);

            return headerPage.Logout();
            
        }
    }
}
