using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); // creating and entering count of numbers
            List<int> res = new List<int>(); // creating vector to save answer
            string[] arr = Console.ReadLine().Split(); // creating array and write number with space
            for (int i = 0; i < n; i++) // go through numbers
            {
                int a = int.Parse(arr[i]);
                res.Add(a); // double enter of numbers
                res.Add(a);
            }

            for (int i = 0; i < res.Count; i++) // show result with space
                Console.Write(res[i] + " ");
            Console.ReadKey(); // system("pause")
        }
    }
}