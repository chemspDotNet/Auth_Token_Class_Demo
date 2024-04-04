using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Auth_Token_Class_Demo.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
    }
}