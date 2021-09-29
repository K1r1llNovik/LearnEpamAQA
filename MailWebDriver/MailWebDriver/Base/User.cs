using System;
using System.Collections.Generic;
using System.Text;

namespace MailWebDriver.Base
{
    public class User
    {
        public string Login { get; set; }
        public string Password { get; set; }


        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}
