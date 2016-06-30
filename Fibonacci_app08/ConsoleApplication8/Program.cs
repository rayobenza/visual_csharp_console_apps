using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64[] fibo;
            fibo = new Int64[52];
            fibo[0] = 1;
            fibo[1] = 1;

            Console.WriteLine("How many Fibonacci numbers shall I show you? (Please enter 2-50)");
            int count = Convert.ToInt16(Console.ReadLine());
            while (count < 2 || count > 50)
            {
                Console.WriteLine("Please enter an integer between 2-50");
                count = Convert.ToInt16(Console.ReadLine());

            }

            Console.WriteLine();
            Console.WriteLine(fibo[0]);
            Console.WriteLine(fibo[1]);

            for (int i = 0; i < count-2; i++)
            {
                fibo[i + 2] = fibo[i] + fibo[i + 1];
                Console.WriteLine(fibo[i + 2]);

            }
            {
                Console.ReadLine();

            }
        }
    }
}
