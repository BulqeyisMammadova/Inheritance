using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Class
{
    internal class Admin:User
    {
        public bool IsSuperAdmin;
        public string Section;

        public Admin(string userName, string passWord,  bool isSuperAdmin, string section, string email = null ) :base(userName,passWord,email)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;

        }

        public void PrintInfo()
        {
            Console.WriteLine($"Username:{UserName},PassWord:{Password},Email:{Email},IsAdmin:{IsSuperAdmin},Section:{Section}");
        }
    }
}
