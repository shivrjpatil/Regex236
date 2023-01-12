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
        public static void ValidateFirstName()
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            string[] Arr = { "Shivraj", "shivraj","Virat","Rohit","Jk" };
            foreach (string input in Arr)
            {
                if(Regex.IsMatch(input,pattern))
                {
                    Console.WriteLine("{0} is valid",input);
                }
                else
                {
                    Console.WriteLine("{0} not valid", input);
                }
            }
        }
        public static void ValidateLastName()
        {
            string pattern = "^[A-Z]{1}[a-z]{3,}$";
            string[] Arr = { "Patil","patil", "Kohli", "Sharma", "Jk" };
            foreach (string input in Arr)
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Console.WriteLine("{0} is valid", input);
                }
                else
                {
                    Console.WriteLine("{0} not valid", input);
                }
            }
        }




    }
}
