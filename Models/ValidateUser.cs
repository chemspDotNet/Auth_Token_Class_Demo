﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_Token_Class_Demo.Models
{
    public class ValidateUser
    {
        public static bool Login(string username, string password)
        {
            UserRepository userBL = new UserRepository();
            var UserLists = userBL.GetUsers();
                    
            return UserLists.Any(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }

        //This method is used to return the User Details
        public static User GetUserDetails(string username, string password)
        {
            UserRepository userBL = new UserRepository();
            return userBL.GetUsers().FirstOrDefault(user =>
                user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                && user.Password == password);
        }
    }
}