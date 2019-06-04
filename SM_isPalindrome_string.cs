// source: Chris Patton
// summary: self made c# console app that answers: "isPalindrome"?
// notes: uses the 'while/if' version of a 'string'
// student: Chris Patton

using System;

class Program
{
    //determines whether the string is a palindrome
	public static bool isPalindrome(string myString)
	{
		string first = myString.Substring(0, myString.Length / 2);
		char[] arr = myString.ToCharArray();
		Array.Reverse(arr);
		string temp = new string(arr);
		string second = temp.Substring(0, temp.Length / 2);
		return first.Equals(second);
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