
using System;

namespace Task3
{
    class MainClass
    {
        public static void doublearr(int[] a, int n)
        {
            int[] b = new int[2 * n];   // create new 2times more array
            int j = 0;                  // j go through 1st array a
            for (int i = 0; i < 2 * n; i += 2)  // go through even numbers of array b and every element go to a[j]
            {
                b[i] = a[j];
                b[i + 1] = a[j];
                Console.Write(b[i] + " " + b[i + 1] + " ");     // show every element of b array
                j++;   // increase j                                       
            }
        }

        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());      // add elements and change it to int
            string[] s = Console.ReadLine().Split();    //read line with space
            int[] a = new int[n];
            for (int i = 0; i < n; i++)    //creating new loop
            {
                a[i] = int.Parse(s[i]);
            }
            doublearr(a, n);          // use a method, where added elements of array and their counting
                                
    }
}