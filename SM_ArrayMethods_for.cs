using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfNumbers
{
    class PrintArray
    {
        //simple print array in order of position
        public void PrintArrayInOrder(int[] intArray)
        {
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                Console.WriteLine(intArray[i]);
            }
        }
		
        //print that sheezy in reverse, dawg
        public void PrintArrayInReverse(int[] intArray)
        {
            for (int i = intArray.Length-1; i >= 0; i--)
            {
                Console.WriteLine(intArray[i]);
            }
        }
		
        //print only the even-divisable numbers in the array
        public void PrintEvenNumbers(int[] intArray)
        {
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    Console.WriteLine(intArray[i]);
                }
            }
        }
		        
		//print only the odd numbers in the array
        public void PrintOddNumbers(int[] intArray)
        {
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    Console.Write(intArray[i]);
                }
            }
        }

        //duplicate array from original
        public int[] GetDup(int[] intArray)
        {
            int[] dupArray = new int[intArray.Length];
            for (int i = 0; i <=intArray.Length -1; i++)
            {
                dupArray[i] = intArray[i];
            }
            return dupArray;
        }

        //instead of printing, reTURNing even numbers!?
        public int[] ReturnEvenNumbers(int[] intArray)
        {
            int counter = 0;
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    //Count
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
                    j++;
                }
            }
            return holderArray;
        }
		
		//return odd numbers in array
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
