
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //enter amount of number
            for (int i = 1; i <= n; i++) //creating a loop to test each of the numbers for simplicity
            {
                for (int j = 1; j <= i; j++) //column and rows
                    Console.Write("[*]");
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}