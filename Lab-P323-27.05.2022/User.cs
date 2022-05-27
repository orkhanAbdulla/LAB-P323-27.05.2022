using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_P323_27._05._2022
{
    class User
    {
        public string Fullname { get; set; }
        public string Email { get; set; }
        private string _password;
        public string Password { 
            get 
            {
                return _password;
            } 
            set 
            {
                if (PasswordChecked(value))
                {
                    _password = value;
                }
            } 
        }
        public User(string email,string password)
        {
            Email = email;
            _password = password;
        }
        public static bool PasswordChecked(string password)
        {
            int LowerCount = 0;
            int UpperCount = 0;
            int DigitCount = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password.Length>7)
                {
                    if (Char.IsLower(password[i]))
                    {
                        LowerCount++;
                    }
                    else if (Char.IsUpper(password[i]))
                    {
                        UpperCount++;
                    }
                    else if (Char.IsDigit(password[i]))
                    {
                        DigitCount++;
                    }
                    if (LowerCount>0 && UpperCount>0 && DigitCount>0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void Showinfo()
        {
            Console.WriteLine($"{Email} {Fullname}");
        }
    }
}
