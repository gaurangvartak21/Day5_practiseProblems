using System;

namespace Prime_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int i;
            int m = 0;
            Console.Write("Enter the Number to check Prime: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i = 2; i <= m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Number is not Prime.");
                    break;
                }
                else
                {
                    Console.Write("Number is  Prime.");
                    break;
                }
            }

        }
    }
}
    
