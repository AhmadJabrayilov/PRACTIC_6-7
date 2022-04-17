using System;
using System.Collections.Generic;
using System.Text;

namespace amin_userTask6_7.Models
{
    internal class Admin:User
    {
        public bool IsSuperAdmin { get; set; }
        public string Section { get; set; }


        public Admin(bool isSuperAdmin,string section,string username, string password):base(username,password)
        {
            IsSuperAdmin = isSuperAdmin;
            Section = section;
        }
        
        public string ShowAdminInfo()
        {
            return $"Username: {UserName}\nPassword {PassWord}\nIs Admin ==> {IsSuperAdmin} / Section==>{Section}";
        }

        public Admin(bool isadmin, string section)
        {
            IsSuperAdmin = isadmin;
            Section = section;
        }
    }
}
