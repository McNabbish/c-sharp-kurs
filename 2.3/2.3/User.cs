using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2._3
{
    class User
    {
        private string password;

        private bool Number(string a)
        {
            string pattern = @"[\d]";
            Match match = Regex.Match(a, pattern);
            if (match.Success)
            {
                Console.WriteLine("New password contains number = true");
                return true;
            }
            else
            {
                Console.WriteLine("Error, Password must contain number");
                return false;
            }
        }
        private bool Uppercase(string a)
        {
            string pattern = "[A-Z]";
            Match match = Regex.Match(a, pattern);
            if (match.Success)
            {
                Console.WriteLine("New password contains Uppercase = true");
                return true;
            }
            else
            {
                Console.WriteLine("Error, Password must contain Uppercase");
                return false;
            }
        }
        private bool Lowercase(string a)
        {
            string pattern = "[a-z]";
            Match match = Regex.Match(a, pattern);
            if (match.Success)
            {
                Console.WriteLine("New password contains lowercase = true");
                return true;
            }
            else
            {
                Console.WriteLine("Error, Password must contain lowercase");
                return false;
            }
        }
        private bool Special(string a)
        {
            string pattern = @"[!-/:-@[-`{-~ ¤]";
            Match match = Regex.Match(a, pattern);
            if (match.Success)
            {
                Console.WriteLine("New password contains Special = true");
                return true;
            }
            else
            {
                Console.WriteLine("Error, Password must contain Special");
                return false;

            }
        }

        private bool Length(string a)
        {
            if (a.Length >= 8)
            {
                Console.WriteLine("New password has sufficient Length = true");
                return true;
            }
            else
            {
                Console.WriteLine("Error, password is to short");
                return false;
            }

        }


        public User()
        {
            password= "F60gT%ft2$U";
        }

        public void ChangePassword(string a)
        {
            if (a == password)
            {
                Console.WriteLine("Input new password, length >= 8 and containing one number and one special character");
                try
                {
                    a = Console.ReadLine();
                }

                catch (Exception e)
                {
                    Console.WriteLine("Input error: {0}", e);
                }

                Console.WriteLine("repeat password: ");

                if (Console.ReadLine() == a && Number(a)==true && Uppercase(a) == true && Lowercase(a) == true && Special(a)==true && Length(a)==true)
                {
                    Console.WriteLine("Password was changed to: {0}", a);
                    password = a;
                }
                    
            }
            else
                Console.WriteLine("Password incorrect");
        }






    }
}
