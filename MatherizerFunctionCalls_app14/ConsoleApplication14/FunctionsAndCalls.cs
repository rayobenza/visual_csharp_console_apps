using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCalls
{
    class Program
    {
        static int GetMeANumber()
        {
            bool loop = true;
            int number = 0;
            while (loop)
            {
                Console.WriteLine("\nType in an integer");
                string answer = Console.ReadLine();
                if (int.TryParse(answer, out number))
                {
                    //Console.WriteLine("You entered the integer " + number);
                    loop = false; // not needed because return leaves a function immediately
                    // return number;
                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            string response = "";
            bool exit = false;

            while (!exit)
            {
                int number1 = 0;
                int number2 = 0;
                string answer = "";

                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("a) add");
                Console.WriteLine("s) subtract");
                Console.WriteLine("m) multiply");
                Console.WriteLine("d) divide");
                Console.WriteLine("x) exit");
                response = Console.ReadLine();
                if (response == "x")
                {
                    Console.WriteLine("\nPress ENTER to quit");
                    Console.ReadLine();
                    exit = true;
                }

                //while (keepLooping1 == true)
                //{
                else
                {
                    number1 = GetMeANumber();
                    //Console.WriteLine("Please enter your first integer");
                    //answer = Console.ReadLine();
                    //if (int.TryParse(answer, out number1))
                    //{
                    //    Console.WriteLine("Thanks for entering first integer " + number1);
                    //    keepLooping1 = false;
                    //}
                    //}

                    //while (keepLooping2 == true)
                    //{
                    number2 = GetMeANumber();
                    //Console.WriteLine("Please enter your second integer");
                    //answer = Console.ReadLine();
                    //if (int.TryParse(answer, out number2))
                    //{
                    //    Console.WriteLine("Thanks for entering second integer " + number2);
                    //    keepLooping2 = false;
                    //}
                    //}
                }
                if (response == "a")
                {
                    Console.WriteLine("\nAdding: " + number1 + " + " + number2 + " = " + (number1 + number2));
                }
                if (response == "s")
                {
                    Console.WriteLine("\nSutracting: " + number1 + " - " + number2 + " = " + (number1 - number2));
                }
                if (response == "m")
                {
                    Console.WriteLine("\nMultiplying: " + number1 + " * " + number2 + " = " + (number1 * number2));
                }
                if (response == "d")
                {
                    Console.WriteLine("\nDividing: " + number1 + " / " + number2 + " = " + (1.0 * number1 / number2));
                }

            }

        }
    }
}
