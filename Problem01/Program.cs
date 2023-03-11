using System;
using System.Collections.Generic;

//////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Google.                                                                                             //
//  Given a list of positive numbers and a number k, return whether any two numbers from the list add up to k.   //
//  For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17                       //
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Problem01
{
    public class Program
    {
        // static int[] listOfNumbers = {10, 15, 3, 7};
        // static int[] listOfNumbers = {23, -6, 10, 6, 15, 3, 7, 10, 10, 4, 5, 8, 3};
        // static int[] listOfNumbers = {};
        // static int[] listOfNumbers = {-12, -5};
        // static int[] listOfNumbers = {12, 5};
        // static int[] listOfNumbers = {23, -6};
        // static int[] listOfNumbers = {17};
        static int[] listOfNumbers = {17, 0, 5};

        public static int[] addsUpToK(int[] numberList, int k)
        {
            var numberDict = new Dictionary<int, int>();

            for (int i = 0; i < numberList.Length; i++)
            {
                var currentNumber = numberList[i];
                if (numberDict.ContainsKey(k - currentNumber))
                {
                    return new int[] {i, numberDict[k - currentNumber]};
                }
                else if (numberDict.ContainsKey(currentNumber))
                {
                    continue;
                }
                else
                {
                    numberDict.Add(currentNumber, i);
                }
            }

            return null;
        }
        public static void Main(string[] args)
        {
            var addsUptoKList  = addsUpToK(listOfNumbers, 17);

            Console.WriteLine(addsUptoKList[0]);
            Console.WriteLine(addsUptoKList[1]);
        }
    }
}
