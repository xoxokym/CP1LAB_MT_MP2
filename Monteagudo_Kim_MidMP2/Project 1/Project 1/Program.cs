using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program using arrays that will accept 15 numbers, then list the odd numbers and even numbers.

            int[] numbers = new int[15];
            int[] eNum = new int[15];
            int[] oNum = new int[15];

            Console.WriteLine("Enter first 15 numbers: ");

            for (int i = 0; i < 15; i++)
            {
                numbers[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            int eCount = 0;
            int oCount = 0;

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    eNum[eCount] = num;
                    eCount++;
                }
                else
                {
                    oNum[oCount] = num;
                    oCount++;
                }
            }

            Console.WriteLine("Even numbers: ");

            for (int i = 0; i < eCount; i++)
            {
                Console.Write(eNum[i] + " \n");
            }

            Console.WriteLine();

            Console.WriteLine("Odd numbers: ");

            for (int i = 0; i < oCount; i++)
            {
                Console.Write(oNum[i] + " \n");
            }

            Console.ReadKey();
        }
    }
}
