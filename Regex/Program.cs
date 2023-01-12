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
            int option=Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Validate.ValidateFirstName();
                    break;
                case 2:
                    Validate.ValidateLastName();
                    break;

            }
            
            Console.ReadLine();
        }
    }
}
