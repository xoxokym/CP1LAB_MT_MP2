using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program that can accept 10 names, then display them in reverse order.

            String[] names = new string[10];

            Console.WriteLine("NAMES IN FIRST ORDER");
            Console.WriteLine();

            for (int x = 0; x < 10; x++)
            {
                Console.Write("Enter a name: ");
                names[x] = Console.ReadLine();
            }

            Console.WriteLine();

            Console.WriteLine("NAMES IN REVERSE ORDER");
            Console.WriteLine();

            for (int x = 9; x >= 0; x--)
            {
                Console.WriteLine(names[x]);
            }

            Console.ReadKey();

        }
    }
}
