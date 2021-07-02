using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            PasswordValidation();
            Console.ReadKey();
        }

        private static void PasswordValidation()
        {
            string valid = "abcdefghijklmnopqrstuvwxyz0123456789.-_";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] validArray = valid.ToCharArray();

            while (true)
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();
                //bool tmp = false;

                if (password.Length >= 8 && password.Length <= 25 && alphabet.Contains(password.ToLower().First()) && alphabet.Contains(password.ToLower().Last()))
                {
                    char[] passArray = password.ToLower().ToCharArray();
                    for (int i = 0; i < passArray.Length; i++)
                    {
                        if (!valid.Contains(passArray[i].ToString()))
                        {
                            //tmp = true;
                            Console.WriteLine("Invalid password. Try again.");
                            break;
                        }
                    }
                    Console.WriteLine("Password confirmed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid password. Try again.");
                }
            }
        }

    }
}
