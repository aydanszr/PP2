using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n; //create variable
            n = int.Parse(Console.ReadLine()); //enter amount of number
            string s = Console.ReadLine();
            string[] arr = s.Split(); //making array for save numbers and enter with space
            int c = 0; //create a var to count primes
            for (int i = 0; i < n; i++) //creating a loop to test each of the numbers for simplicity
            {
                int b = int.Parse(arr[i]); //convert array element to number
                if (isPrime(b) == true) // check number for prime
                {
                    c++;
                }
            }
            Console.WriteLine(c); //show count

            for (int i = 0; i < n; i++)
            {
                int b = int.Parse(arr[i]);
                if (isPrime(b) == true)
                {
                    Console.Write(b + " "); //show prime numbers with space
                }
            }

            Console.ReadKey();

        }

        public static bool isPrime(int a) //creating a function to check prime
        {
            bool w = true;
            if (a == 1) w = false;

            for (int i = 2; i < a; i++) //enough to divide number to prev one 
            {
                if (a % i == 0)
                {
                    w = false;
                }

            }
            return w;

        }
    }
}
