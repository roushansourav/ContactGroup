using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace req3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Email Validation\n2.Service Provider Identification\nEnter your choice:");
            //fill code here.
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Console.WriteLine("Enter the email to be validated:");
                    if(Program.ValidateEmailId(Console.ReadLine()))
                        Console.WriteLine("Email is valid");
                    else
                        Console.WriteLine("Email is invalid");
                    break;
                case 2:
                    Console.WriteLine("Enter the mobile number to identify the service provider:");
                    
                    string service = Program.IdentifyServiceProvider(Console.ReadLine());
                    if (service != null)
                    {
                        Console.WriteLine("Mobile number belongs to " + service);
                    }
                    else
                        Console.WriteLine("Mobile number is not identified");
                      
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
                   
            }
        }
        public static bool ValidateEmailId(string email)
        {
            //fill code here.
            string pattern = @"^[A-Za-z]{1}[\w\._]+@[a-zA-Z]+\.[a-zA-Z]{2,6}$";
            return Regex.IsMatch(email, pattern);
        }
        public static string IdentifyServiceProvider(string mobile)
        {
            //fill code here.
            string start = mobile.Substring(0, 4);
            if (start == "9870")
                return "Airtel";
            else if (start == "7012")
                return "Jio";
            else if (start == "8180")
                return "Vodafone";
            else
                return null;

        }
        
    }
}
