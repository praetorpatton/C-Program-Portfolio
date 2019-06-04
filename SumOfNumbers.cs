// source: https://www.sanfoundry.com/csharp-program-boxing-operations/
// author: Sanfoundry
// summary: c# console app that adds all the numbers within a user-typed number
// modifications: tried to change the values of addition to each digit,
// but without parsing each digit of a number into an array. Did not work.
// student: Chris Patton
// capture date: 20 Apr 2019

{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
			int sum = 0;
			int r;
            Console.WriteLine("Enter a Number : ");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                r = num % 10;
                num = num / 10;
                sum = sum + r;
            }
            Console.WriteLine("Sum of Digits of the Number : "+sum);
            Console.ReadLine();
 
        }
    }
}