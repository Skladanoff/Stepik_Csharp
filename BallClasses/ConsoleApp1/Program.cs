using System;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a;
            a = b;
            b = c;

            Console.WriteLine(a + " " + b);
        }
    }
}