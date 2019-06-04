// source: Hands-On Object-Oriented Programming with C#
// author: Raihan Taher
// summary: Adding the digits of a number.
// modifications: changed loop and converted int to long
// student: Chris Patton
// capture date: 05 Apr 2019


using System;

namespace sumOfDigitsInANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                long sum = 0;
                Console.WriteLine("Enter a Number : ");
                long num = long.Parse(Console.ReadLine());
                //Converts the user's input from a string to a long variable type.
                while (num != 0)
                {
                    long r = num % 10;
                    num = num / 10;
                    sum = sum + r;
                    Console.WriteLine("sum = {0}", sum);
                }
                Console.WriteLine("Sum of Digits of the Number : " + sum);
                Console.WriteLine("Try again?  (Y/N) ");
                if (Console.ReadLine().ToLower() != "y")
                    break;
            }
        }
    }
}
