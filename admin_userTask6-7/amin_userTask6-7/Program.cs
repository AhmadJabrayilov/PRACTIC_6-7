using amin_userTask6_7.Models;
using System;

namespace amin_userTask6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string userName;
            string passWord;


            Admin admin = new Admin(true,"Log in");

            do
            {
                Console.Write("input Admin Username: ");
                userName = Console.ReadLine();
            } while (userName.Length < 6 || userName.Length > 20);

            do
            {
                Console.Write("input Admin Password: ");
                passWord = Console.ReadLine();
            } while (!admin.PassWordChecker(passWord));

            admin.IsSuperAdmin = true;
            admin.Section = "log in";
            

            

            admin.ShowAdminInfo();

        }

       
    }
}
