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
    }
}
