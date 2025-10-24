using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    internal class User
    {
        public string UserName;
        public string Password;
        public string Email;

        public User(string userName, string passWord, string email = null)
        {
            UserName = userName;
            Password = passWord;
            Email = email;
        }
    }
}
