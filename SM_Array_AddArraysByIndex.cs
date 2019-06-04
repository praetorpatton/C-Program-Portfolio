// author: Chris Patton
// summary: Self-made program with for adding arrays that will  
// RETURN THE INDEX OF Array1 WITH THE INDEX of Array2 declared in the main method.
// notes: created a sumArray char[] to hold the multiple of char[] results
// student: Chris Patton

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcom to Array Land!");
            ArrayClass print1 = new ArrayClass();

            int[] intArray1 = new int[3] { 1, 3, 5 };
            int[] intArray2 = new int[3] { 2, 4, 6 };
            //int[] sumArray = new int[intArray1.Length * intArray2.length]; (don't need, as it's declared in the class method)
            sumArray = print1.AddTheArrays(intArray1, intArray2);
            Console.ReadLine();
        }
    }
}

	class ArrayClass
		{
			public int[] AddTheArrays(int[] intArray1, int[] intArray2) //int[] sumArray(dont' need here, method only needs 1&2)
			{
				int[] sumArray = new int[intArray1.Length * intArray2.Length];
				int k = 0;
				for (int i = 0; i <= intArray1.Length -1; i++)
				{
					for (int j = 0; j <= intArray2.Length -1; j++)
					{
						sumArray[k] = intArray1[i] + intArray2[j];
						k++;
					}
					//return sumArray; (don't use here, returns in this loop only)
				}
				return sumArray;
			}
		}