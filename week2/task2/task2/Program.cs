using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;


namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "/Users/aydan/Desktop/week2/task2i.txt";
            var output = "/Users/aydan/Desktop/week2/task2o.txt";
            StreamReader reader = new StreamReader(input);
            string[] s = reader.ReadToEnd().Split();
            reader.Close();
            List<int> ans = new List<int>();
            for (int it = 0; it < s.Count(); it++)
            {
                int a = int.Parse(s[it]);
                int prime = 1;
                for (int i = 2; i <= (int)Math.Sqrt(a) && prime == 1; i++)
                    if (a % i == 0)
                        prime = 0;
                if (a != 1 && prime == 1)
                    ans.Add(a);
            }
            StreamWriter writer = new StreamWriter(output);
            for (int i = 0; i < ans.Count(); i++)
                writer.Write(ans[i] + " ");
            writer.Close();
            Console.ReadKey();
        }
    }
}
