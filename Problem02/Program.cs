using System;
using System.Collections.Generic;

/////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Uber.                                                                                              //
//  Given an array of integers, return a new array such that each element at index i of the new array  //
//  is the product of all the numbers in the original array except the one at i.                       //
//  For example, if our input was [1, 2, 3, 4, 5], the expected output would be [120, 60, 40, 30, 24]. //
//  If our input was [3, 2, 1], the expected output would be [2, 3, 6].                                //
/////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Problem02
{
    class Program
    {
        static int[] input = {1, 2, 3, 4, 5};
        // static int[] input = {1, 5};
        //static int[] input = {3, 2, 1};

        public static int[] getArrayOfMultiples(int[] input)
        {
            int len = input.Length;
            int[] arrayOfMultiples = new int[len];

            if (len > 2)
            {
                int total = 1;

                for (int i = 0; i < len; i++)
                {
                    total *= input[i];
                }
                for (int j = 0; j < len; j++)
                {
                    arrayOfMultiples[j] = total / input[j];
                }
            }
            else
            {
                Console.WriteLine("Insufficient number of elements in array, min of 3 elements needed");
                return input;
            }
            return arrayOfMultiples;
        }
        static void Main(string[] args)
        {
            int[] arrayOfMultiples = getArrayOfMultiples(input);

            for (int i = 0; i < arrayOfMultiples.Length; i++)
            {
                Console.WriteLine(arrayOfMultiples[i]);
            }   
        }
    }
}
