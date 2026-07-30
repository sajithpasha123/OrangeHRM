using System;
using System.Collections.Generic;
using System.Text;
using OrangeHRM.Models;

namespace OrangeHRM.Utilities
{
    public static class UserManager
    {
        private static readonly User user = new User
        {
            UserName = "user@gmail.com",
            Password = "password1"
        };

        private static readonly User admin = new User
        {
            UserName = "admin@gmail.com",
            Password = "password2"
        };

        public static string CurrentUser { get; set; } = "User";

        public static User GetCurrentUser()
        {
            switch (CurrentUser.ToLower())
            {
                case "admin":
                    return admin;

                case "user":
                    return user;

                default:
                    throw new Exception($"User '{CurrentUser}' is not configured.");
            }
        }
    }
}
