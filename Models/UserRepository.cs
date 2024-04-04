using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_Token_Class_Demo.Models
{
    public class UserRepository
    {
       static List<User> _users;
     public  UserRepository()
        {
            _users = new List<User>()
                  {
                      new User() {
                           ID = 101,
                           UserName = "AdminUser",
                           Password = "abc@123",
                           Role = "Admin",
                           Email = "admin@test.com"
                      },
                     new User() {
                           ID = 102,
                           UserName = "MemberUser",
                           Password = "abc@123",
                           Role = "Member",
                           Email = "member@test.com"
                      },
                  };
        }

        public List<User> GetUsers()
        {
            return _users;
        }


        public void AddUser(User user)
        {
            _users.Add(user);
        }
    }
}