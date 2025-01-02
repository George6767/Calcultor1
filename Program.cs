using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool restrt = true;

            Console.WriteLine("Hello, welcome to the calculator programm!");

            while (restrt)
            {

                int num1;
                int num2;
                string answer, input;

                int result;

                Console.WriteLine("Please, enter your first number.");

                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please, enter your second number.");

                num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What type of operation would you like to do?");
                Console.WriteLine("Please enter a for addition, s for substraction, m fro multiplication, or d for division.");

                answer = Console.ReadLine();

                if (answer == "a")
                {
                    result = num1 + num2;
                }
                else if (answer == "s")
                {
                    result = num1 - num2;
                }
                else if (answer == "m")
                {
                    result = num1 * num2;
                }
                else
                {
                    result = num1 / num2;
                }


                Console.WriteLine("The result is " + result);

                Console.WriteLine("If you want to repeat, put yes, if you want to finish programm, put no.");

                input = Console.ReadLine();

                if (input.ToLower() == "yes")
                {
                    restrt = true;
                }
                else
                {
                    restrt = false;
                }

            }

            Console.WriteLine("Thank you for using the calculator program!!!");

            Console.ReadKey();
        }
    }
}
