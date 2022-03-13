using System;

namespace Reverse_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int reverse = 0;
            int reminder;
            Console.Write("Enter a number: ");
            n = int.Parse(Console.ReadLine());
            while (n!= 0)
            {
                reminder = n % 10;
                reverse = reverse * 10 + reminder;
                n /= 10;
            }
            Console.Write("Reversed Number is " + reverse);
        }
    }
}
    

