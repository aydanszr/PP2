using System;
using System.IO;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = "/Users/aydan/Desktop/week2/task1i.txt";
            StreamReader reader = new StreamReader(input);
            string s = reader.ReadToEnd();
            string t = s;
            reader.Close();
            bool check = true;
            for (int i = 0; i < s.Length && check == true; i++)
                if (t[s.Length - i - 1] != s[i])
                    check = false;
            if (check == true)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            Console.ReadKey();
        }
    }
}
