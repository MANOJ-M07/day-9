using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleAppRegExExample
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
            List<string> list = new List<string>()
            {"Aman","Amit","Vijay","Mohan","Manoj"};
            string pattern = @"\b[M]\w+";*/

            //string mobPattern = @"^\d{10}$";
            //Regex regex = new Regex(mobPattern);
            ///*string mobPattern = "[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]";*/
            //string[] mobiles = new string[] { "+91-8234657950", "8564321526", "+91-8594678520", "+91-8956237412", "9865328754", "+91-8637641952" };
            //foreach (string mobile in mobiles)
            //{
            //    if (regex.IsMatch(mobile))
            //    {
            //        Console.WriteLine("{0} is a valid mobile number", mobile);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is not a valid mobile number", mobile);
            //    }
            //}
            //Console.ReadKey();



            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Please enter your mobile number:");
            string mobileNumber = Console.ReadLine();

            Console.WriteLine("Please enter your PIN code:");
            string pinCode = Console.ReadLine();

            if (IsValidName(name) && IsValidMobileNumber(mobileNumber) && IsValidPinCode(pinCode))
            {
                Console.WriteLine("All inputs are valid!");
            }
            else
            {
                Console.WriteLine("Invalid inputs! Please check your inputs and try again.");
            }
        }

        static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name) && name.All(char.IsLetter);
        }

        static bool IsValidMobileNumber(string mobileNumber)
        {
            return !string.IsNullOrWhiteSpace(mobileNumber) && mobileNumber.Length == 6 && mobileNumber.All(char.IsDigit);
        }

        static bool IsValidPinCode(string pinCode)
        {
            return !string.IsNullOrWhiteSpace(pinCode) && pinCode.Length == 5 && pinCode.All(char.IsDigit);

            Console.ReadKey();
        }

    }
    
}
