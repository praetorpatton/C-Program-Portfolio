// author: Chris Patton
// summary: Self-made program with an added methods (.cs) 
// for printing an arrays or returning arrays.
// RETURNS ODD NUMBERS from array in order of position.
// notes: 'PrintArray' type was created within the solution 
// student: Chris Patton

using System;
using System.Collections.Generic;
using System.Text;

    class PrintArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here's my array: ");
			
            PrintArray print1 = new PrintArray();
            int[] intArray = new int[5] { 3, 4, 7, 9, 22 };
		}
		
		public int[] ReturnOddNumbers(int[] intArray)
        {
            int counter = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    //Count
                    counter++;
                }
            }
            int[] holderArray = new int[counter];
            int j = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    holderArray[j] = intArray[i];
                    j++;
                }
            }
            return holderArray;
        }
	}	