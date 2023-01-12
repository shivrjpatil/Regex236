using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegulerExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reguler Expression");
            Console.WriteLine("Choose one option");
            Console.WriteLine("1.To Validate FirstName\n2.To Validate lastName\n3.To Validate EmailId");
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.WriteLine("Enter the first name");
                    string Firstname=Console.ReadLine();
                    Validate.ValidateFirstName(Firstname);
                    break;
                case 2:
                    Console.WriteLine("Enter the last name");
                    string lastname=Console.ReadLine(); 
                    Validate.ValidateLastName(lastname);
                    break;
                case 3:
                    Console.WriteLine("Eneter the email id");
                    string Email = Console.ReadLine();
                    Validate.ValidateEmailId(Email);
                    break;

            }
            
            Console.ReadLine();
        }
    }
}
