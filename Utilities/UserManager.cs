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
            UserName = "Admin",
            Password = "admin123"
        };

        public static string CurrentUser { get; set; } = "Admin";

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
