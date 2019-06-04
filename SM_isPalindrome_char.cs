// source: Chris Patton
// summary: self made c# console app that answers: "isPalindrome"?
// notes: uses the 'while/if' version of a 'char'
// student: Chris Patton

using System;

class Program
{
    //determines whether the string is a palindrome
    public static bool IsPalindrome(string value)
    {
        int min = 0;
        int max = value.Length - 1;
        while (true)
        {
            if (min > max)
            {
                return true;
            }
            char a = value[min];
            char b = value[max];
            if (char.ToLower(a) != char.ToLower(b))
            {
                return false;
            }
            min++;
            max--;
        }
    }

    static void Main()
    {
		//same example sets of palindromes for compare
        string[] array =
        {
            "civic",
            "deified",
            "deleveled",
            "devoved",
            "dewed",
            "Hannah",
            "kayak",
            "level",
            "madam",
            "racecar",
            "radar",
            "redder",
            "refer",
            "repaper",
            "reviver",
            "rotator",
            "rotor",
            "sagas",
            "solos",
            "sexes",
            "stats",
            "tenet",

            "Dot",
            "Net",
            "Perls",
            "Is",
            "Not",
            "A",
            "Palindrome",
            ""
        };

        foreach (string value in array)
        {
            Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
        }
    }
}