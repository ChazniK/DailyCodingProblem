using System;
using System.Collections.Generic;

//////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Google.                                                          //
//  Given a list of numbers and a number k, return whether any two numbers from the list add up to k.   //
//  For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17                       //
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Problem_01
{
    class Program
    {
        // static int[] listOfNumbers = {10, 15, 3, 7};
        // static int[] listOfNumbers = {23, -6, 10, 6, 15, 3, 7, 10, 10, 4, 5, 8, 3};
        // static int[] listOfNumbers = {};
        // static int[] listOfNumbers = {-12, -5};
        // static int[] listOfNumbers = {12, 5};
        // static int[] listOfNumbers = {23, -6};
        // static int[] listOfNumbers = {17};
        static int[] listOfNumbers = {17, 0, 5};

        static public bool addsUpToK(int[] numberList, int k)
        {
            int listLength = numberList.Length;
            Dictionary<int, int> dict = new Dictionary<int, int>();

            if (listLength > 1)
            {
                for (int i = 0; i < listLength; i++)
                {
                    int currentNumber = numberList[i];
                    
                    if (dict.ContainsKey(k - currentNumber))
                    {
                        return true;
                    }
                    else if (dict.ContainsKey(currentNumber))
                    {
                        continue;
                    }
                    else
                    {
                        dict.Add(currentNumber, 1);
                    }
                }
            } 
            return false;                
        }
        static void Main(string[] args)
        {
            Console.WriteLine(addsUpToK(listOfNumbers, 17));   
        }
    }
}
