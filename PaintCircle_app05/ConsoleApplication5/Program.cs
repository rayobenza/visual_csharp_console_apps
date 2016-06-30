using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            // You are helping with a local soccer league
            // They need to be able to paint their fields
            // to mark the center circle. Different leagues
            // have different sized circles, however. Make
            // a program that will ask for the size of the
            // circle and then tell them how much paint they
            // need to cover the center circle. The paint
            // they use covers about 100 sq ft per bucket.
            // Make sure they have enough paint, it's ok
            // if there is some extra left in the last
            // bucket

            // Show the output like this:
            // It will take 8 buckets to paint the 15' circle

            // Bonus: Different colors cover better than
            // others. Let the user pick the color and show
            // the result. The colors are as follows:
            // Red = 100 sq ft/bucket
            // Blue = 120 sq ft/bucket
            // Green = 90 sq ft/bucket
            // Yellow = 70 sq ft/bucket

            // Extra Bonus: The colors also cost different
            // amounts. Tell the user how much it will cost
            // to paint their field.
            // Red = 25$ / bucket
            // Blue = 28$ / bucket
            // Green = 33$ / bucket
            // Yellow = 22$ / bucket

            int diameter;
            string response;
            Console.WriteLine("What is the diameter of your circle?");
            response = Console.ReadLine();
            diameter = Convert.ToInt16(response);

            // double area = Math.PI * Math.Pow((diameter / 2.0), 2);

            string color;
            Console.WriteLine("What color will your circle be? (red, blue, green, or yellow)");
            color = Console.ReadLine();

            /*
            int numberOfBuckets = 1;  // assigned a default value of 1 so that it's never unassigned
            if (color.ToLower() == "red")
            {
                numberOfBuckets = Convet.ToInt16(Mth.Ceiling(area / 100)
            }
            */

            /*
            double area = Math.PI * Math.Pow((diameter / 2.0), 2);
            int coverage = 1;  // assigned a default value of 1 so that it's never unassigned
            int cost = 1;  // assigned a default value of 1 so that it's never unassigned

            switch (color)
            {
                case "red":
                    coverage = 100;
                    cost = 25;
                    break;

                case "blue":
                    coverage = 100;
                    cost = 25;
                    break;

                case "green":
                    coverage = 100;
                    cost = 25;
                    break;

                case "yellow":
                    Console.WriteLine("It will take " + (Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 70)) + " buckets to paint the " + diameter + "' circle.");
                    break;
            }
            Console.WriteLine("It will take " + Math.Ceiling(area / coverage) + " buckets to paint the " + diameter + "' circle.");
            Console.WriteLine("It will cost $" + Math.Ceiling(area / coverage) * cost) + " to paint it " + color + ".");
            }
            */

            switch (color)
            {
                case "red":
                    Console.WriteLine("It will take " + (Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 100)) + " buckets to paint the " + diameter + "' circle.");
                    Console.WriteLine("It will cost $" + ((Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 100)) * 25) + " to paint it " + color + ".");
                    Console.WriteLine("Are you sure you don't want to paint it yellow? That would only cost $" + ((Math.Ceiling(Math.PI * (diameter / 2) * (diameter / 2) / 100)) * 22) + ".");
                    break;

                case "blue":
                    Console.WriteLine("It will take " + (Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 120)) + " buckets to paint the " + diameter + "' circle.");
                    Console.WriteLine("It will cost $" + ((Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 100)) * 28) + " to paint it " + color + ".");
                    Console.WriteLine("Are you sure you don't want to paint it yellow? That would only cost $" + ((Math.Ceiling(Math.PI * (diameter / 2) * (diameter / 2) / 100)) * 22) + ".");
                    break;

                case "green":
                    Console.WriteLine("It will take " + (Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 90)) + " buckets to paint the " + diameter + "' circle.");
                    Console.WriteLine("It will cost $" + ((Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 100)) * 33) + " to paint it " + color + ".");
                    Console.WriteLine("Are you sure you don't want to paint it yellow? That would only cost $" + ((Math.Ceiling(Math.PI * (diameter / 2) * (diameter / 2) / 100)) * 22) + ".");
                    break;

                case "yellow":
                    Console.WriteLine("It will take " + (Math.Ceiling(Math.PI * (diameter / 2.0) * (diameter / 2.0) / 70)) + " buckets to paint the " + diameter +"' circle.");
                    break;

            }
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Hey, this is fun!");
                Console.ReadLine();
            }
            }
        }
}
