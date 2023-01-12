using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegulerExpression
{
    internal class Validate
    {
        public static void ValidateFirstName(string FirstName)
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
                if(Regex.IsMatch(FirstName,pattern))
                {
                    Console.WriteLine("{0} is valid",FirstName);
                }
                else
                {
                    Console.WriteLine("{0} not valid",FirstName);
                }
        }
        public static void ValidateLastName(string LastName)
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
           
                if (Regex.IsMatch(LastName, pattern))
                {
                    Console.WriteLine("{0} is valid", LastName);
                }
                else
                {
                    Console.WriteLine("{0} not valid", LastName);
                }            
        }
        public static void ValidateEmailId(string Email)
        {
            string pattern = "^[a-zA-Z0-9]+([.][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]+([.][a-zA-Z]+)?$";
            if (Regex.IsMatch(Email, pattern))
                {
                    Console.WriteLine("{0} is valid", Email);
                }
                else
                {
                    Console.WriteLine("{0} not valid", Email);
                }
        }
        public static void ValidateMobileNumber(string MobileNumber)
        {
            string pattern = "^[0-9]{2}[ ]{1}[0-9]{10}$";
            if (Regex.IsMatch(MobileNumber, pattern))
            {
                Console.WriteLine("{0} is valid", MobileNumber);
            }
            else
            {
                Console.WriteLine("{0} not valid", MobileNumber);
            }
        }
        public static void Validatepassword(string Password)
        {
            // string pattern = "^[a-zA-Z0-9]{8,}$";
            // string pattern = "^[A-Z]{1,}[a-zA-Z0-9]{8,}$";
            //string pattern = "^[A-Z]{1,}[0-9]{1,}[a-zA-Z0-9]{8,}$";
            string pattern = "^[!@#$^&*~]{1,}[A-Z]{1,}[0-9]{1,}[a-zA-Z0-9]{8,}$";
            


            if (Regex.IsMatch(Password, pattern))
            {
                Console.WriteLine("{0} is valid", Password);
            }
            else
            {
                Console.WriteLine("{0} not valid", Password);
            }
        }
        public static void validateGivenEmails()
        {
            string pattern = "^[a-zA-Z]{3}[_,.,+,-]?[a-zA-Z0-9]*@[a-zA-Z0-9]{1,10}.(com|com.au|net|co.in|com.com)$";
            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", "abc.100@abc.com.au", "abc@1.com" ,"abc@gmail.com.com", "abc+100@gmail.com" };
            TestPattern(pattern, arr);
        }
        //Created Test pattern method
        public static void TestPattern(string pattern, string[] arr)
        {
            foreach (string inputs in arr)
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0} is valid", inputs);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", inputs);
                }
            }
        }
    }
}
