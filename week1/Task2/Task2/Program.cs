using System;

namespace task1
{
    class Student
    {
        public string name;
        public string id;
        public int year = 0;
        public Student(string name, string id)
        {
            this.name = name;
            this.id = id;
        }
        public void PrintInfo()
        {
            year++;

            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Aydan", "18BD1234567");
            s.PrintInfo();
        }
    }
}
