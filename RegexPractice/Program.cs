using System;
using System.Text.RegularExpressions;
using System.Threading;

namespace RegexPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
   
            
            

            Console.WriteLine("Choose the option you want to validate: \n1. Email ID\n2. PIN Code");
            int input = Convert.ToInt32(Console.ReadLine());
            Program call = new Program();
            switch(input)
            {
                case 1:
                    emailValidation();

                    break;
                case 2:
                    pinCodeValidation();
                    break;
            }    
           




        }

        public static void emailValidation()
        {
            string eMail = "[a-zA-Z0-9]+([+-_.][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]{2})*$";
            Console.WriteLine("Enter the email ID you want to validate: ");
            string input = Console.ReadLine();

            Regex re = new Regex(eMail);
            if (re.IsMatch(input))
                Console.WriteLine("Email ID is valid");
            else
                Console.WriteLine("Email ID is not valid");
        }

        public static bool pinCodeValidation()
        {
            string pinCode = "^[1-9]{1}([0-9]*[ ]?[0-9]+){5,6}$";
            Console.WriteLine("Enter the PIN Code you want to validate: ");
            string input = Console.ReadLine();

            Regex re = new Regex(pinCode);
            if (re.IsMatch(input))
                return true;
            else
                return false;

        }

    }
}
