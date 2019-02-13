using System;
using System.IO;


namespace Task4
{
    class Program
    {

        static void Main(string[] args)
        {
            string fileName = "task4.txt"; // задаю название файла
            string sourcePath = "/Users/aydan/PP2/week2/task4";         
            string targetPath = "/Users/aydan/PP2/week2/task4/copy"; 

            string sourceFile = System.IO.Path.Combine(sourcePath, fileName); 
            string destFile = System.IO.Path.Combine(targetPath, fileName);


            using (FileStream fs = new FileStream(sourceFile, FileMode.CreateNew, FileAccess.Write)) 
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write("hello,world");
                }
            }

            System.IO.File.Copy(sourceFile, destFile, true); // 
            System.IO.File.Delete(sourceFile); // 

        }
    }
}