using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a program using loops that will display the multiplication table (table of 10).

            for (int x = 1; x <= 10; x++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write(x * i + "\t");
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
