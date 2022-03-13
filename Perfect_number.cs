using System;

namespace Perfect_number
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int number;
            int total = 0;
            int a;
            Console.Write("enter any Number");
            number = int.Parse(Console.ReadLine());
            a = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    total = total + i;
                }
            }
            if (total == a)
            {
                Console.WriteLine("The number is a perfect number");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("The number is not a perfect number");
                Console.ReadLine();
            }
        }
    }
}
    

