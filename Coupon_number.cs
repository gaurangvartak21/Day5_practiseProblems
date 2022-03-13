using System;

namespace coupon_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[5];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalstring = new string(stringChars);
            Console.WriteLine("Coupon number is " + finalstring);
        }
    }
}
