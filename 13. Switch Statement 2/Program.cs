using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Switch_Statement_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number between 1 and 3 ");

            string number = Console.ReadLine();

            if (int.TryParse(number, out int result)) //this test if the entered value is indeed an integer before converting the string to int 
            {
                int number1 = int.Parse(number);
                switch (number1) 
                {
                    case 1:
                        Console.WriteLine("You enter number 1 ");
                        break;

                    case 2:
                        Console.WriteLine("You entered number 2 ");
                        break;

                    case 3:
                        Console.WriteLine("You entered number 3 ");
                        break;

                    default:
                        Console.WriteLine("You broke the rules, your number is out of ranger please enter a number between 1 and 3");
                        break;
                }
            }

            else 
            {
                Console.WriteLine("Not an Integer, please enter an Integer between 1 and 3 ");
            }
        }
    }
}


           
