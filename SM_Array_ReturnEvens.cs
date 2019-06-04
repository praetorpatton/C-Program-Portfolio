// author: Chris Patton
// summary: Self-made program with an added methods (.cs) 
// for printing an arrays or returning arrays.
// RETURNS EVEN NUMBERS from array in order of position.
// notes: 'print1' ref type was created within the solution 
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
			print1.PrintArrayInOrder(intArray);
            print1.PrintArrayInReverse(intArray);
            print1.PrintEvenNumbers(intArray);
            print1.PrintOddNumbers(intArray);
            int[] duplicateFromSomewhere = print1.GetDup(intArray);
            int[] evenNumberArray = print1.ReturnEvenNumbers(intArray);
            print1.ReturnOddNumbers(intArray);
		}
		
		public int[] ReturnEvenNumbers(int[] intArray)
        {
            int counter = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    //Count the number of evens from 'intArray'
                    counter++;
                }
            }
            int[] holderArray = new int[counter];
            int j = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    holderArray[j] = intArray[i];
					//have to increment 'j' because it starts at [0], 
					//and we need the first even number to be placed
					//inside [0], but increase in size as more evens come
                    j++;
                }
            }
            return holderArray;
        }

	}