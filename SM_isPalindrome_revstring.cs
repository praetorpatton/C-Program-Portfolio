// source: Chris Patton
// summary: self made c# console app that answers: "isPalindrome"?
// notes: uses the 'for' loop with 'if' embed. not as clear as char[] method.
// student: Chris Patton

using System;

class Program
{
    //determines whether the string is a palindrome
	{  
        static void Main(string[] args)  
        {  
            string s,revs="";  
            Console.WriteLine(" Enter string");  
            s = Console.ReadLine();
			//reverse the string
            for (int i = s.Length-1; i >=0; i--) 
            {  
                revs += s[i].ToString();  
            }  
			//checks whether string is palindrome or not  
            if (revs == s) 
            {  
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
            }  
            else  
            {  
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", s, revs);  
            }  
            Console.ReadKey();  
        }
	}
}