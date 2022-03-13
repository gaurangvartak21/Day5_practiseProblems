using System;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=0;
            int b=1;
            int c;
            int i;
            int number;
            Console.WriteLine("Enter the number of elements");
            number =int.Parse(Console.ReadLine());
            Console.WriteLine(a + " ");
            Console.WriteLine(b + " ");
            for (i = 2; i < number; i++)
            {
                c = a + b;
                Console.WriteLine(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
