// source: https://stackoverflow.com/questions/9086168/random-number-guessing-game
// author: initially from "john" from thread
// summary: raw c# console app playing the "high-low game"
// modifications: program would not read user input correctly.
// figured out that it was displaying the ASCCI "char" values instead of as a "string"
// changed the user input to readline to make sure it ran only int values. input a ReadLine
// at the end or else the user never saw their results.
// student: Chris Patton
// capture date: 17 Apr 2019

{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int returnValue = random.Next(1, 100);
            int Guess = 0;
            int numGuesses = 0;

            Console.WriteLine("I am thinking of a number between 1-100.  Can you guess what it is?");

            while (Guess != returnValue)
            {
                //var test = Console.ReadLine(); changed Read to ReadLine to receive STRING value, not CHAR
                //Guess = Convert.ToInt32(test); tryparse below worked better 
                string line = Console.ReadLine(); // Get int string from the user
                if (!int.TryParse(line, out Guess)) // Try to parse the string as an integer
                    Console.WriteLine("Not an whole number, try again!");
                else
                {
                    numGuesses++;
                    if (Guess < returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is higher than " + Guess + " .  Can you guess what it is?");
                    }
                      if (Guess > returnValue)
                    {
                        Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
                    }
                }
            }
            Console.WriteLine("Well done! The answer was " + returnValue + ".\nYou took " + numGuesses + " guesses.");
            Console.ReadLine(); //added readline to ensure user see the writeline above for results

        }
    }
}
