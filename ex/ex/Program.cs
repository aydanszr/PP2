using System;

namespace ex
{
    class triangle
    {
        private int a;
        private int b;
        private int c;

        public triangle(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

        }
        public int getPerimetr()
        {
            return a + b + c;
        }


        class Program
        {
            static void Main(string[] args)
            {
                triangle t = new triangle(3, 4, 5);
                Console.WriteLine(t.getPerimetr());

            }
        }
    }
}