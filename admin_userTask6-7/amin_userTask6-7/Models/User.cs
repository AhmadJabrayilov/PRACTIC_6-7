using System;
using System.Collections.Generic;
using System.Text;

namespace amin_userTask6_7.Models
{
    internal class User
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                if (value.Length > 6 && value.Length < 20)
                {
                    _userName = value;
                }
            }
        }

        private string _passWord;

        public string PassWord
        {
            get { return _passWord; }
            set
            {
                if (PassWordChecker(value))
                {
                    _passWord = value;
                }
            }
        }


         public bool PassWordChecker(string passWord)
        {
            bool hasUpper = false;
            bool hasNumber = false;


            if (passWord.Length >= 8)
            {
                foreach (var item in passWord)
                {
                    if (char.IsNumber(item)) 
                    {
                        hasNumber = true;
                    }

                    if (char.IsUpper(item))
                    {
                        hasUpper = true;
                    }

                    if (hasNumber && hasUpper)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public User(string username, string password)
        {
            UserName = username;
            PassWord = password;
        }

        public User()
        {

        }
    }
}
