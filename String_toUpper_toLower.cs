// source: https://www.sanfoundry.com/
// author: Sanfoundry
// summary: c# console app that changes string contents from uppercase to lowercase
// modifications: added a 'to.Upper()' for a lower case string to demos both functions
// student: Chris Patton
// capture date: 28 Apr 2019

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreStrings
{
    class Program
    {
        static void Main(string[] args)
		{
            string str;
            string str2;
            Console.WriteLine("Enter an UPPERCASE String:");
            str = Console.ReadLine();
            Console.WriteLine("String in LOWERCASE : {0}", str.ToLower());

            Console.WriteLine("Enter an LOWERCASE String:");
            str2 = Console.ReadLine();
            Console.WriteLine("String in UPPERCASE : {0}", str2.ToUpper());

            Console.ReadLine();
		}
	}
}