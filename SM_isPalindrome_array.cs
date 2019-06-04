// source: Chris Patton
// summary: self made c# console app that answers: "isPalindrome"?
// notes: uses the 'while/if' version of a 'string'
// student: Chris Patton

using System;

class Program
{
    //determines whether the string is a palindrome
	public static bool isPalindrome(string str)
	{
    int i = 0;
    int j = str.Length - 1;

    while (i<j)
    {
        if (str[i] != str[j])
            return false;

        i++;
        j--;
    }

    return true;
	}
	
    static void Main()
    {
		//same example set of palindromes for compare
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
        };

        foreach (string value in array)
        {
            Console.WriteLine("{0} = {1}", value, IsPalindrome(value));
        }
    }
