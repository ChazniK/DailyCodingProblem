using System;

//////////////////////////////////////////////////////////////////////////////////////////////////////////
//  Dropbox.                                                                                            //
//  Spreadsheets often use this alphabetical encoding for its columns:                                  //
//  "A", "B", "C", ..., "AA", "AB", ..., "ZZ", "AAA", "AAB", ....                                       //
//  Given a column number, return its alphabetical column id.                                           //
//  For example, given 1, return "A". Given 27, return "AA".                                            //
//////////////////////////////////////////////////////////////////////////////////////////////////////////

namespace Problem212
{
    class Program
    {
        private static char [] _alphabetList = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        private static string getAlphabetColumnId(int columnNumber)
        {
            string alphabeticalColumnId = string.Empty;
            int numberOfMultiples = 0;
            int remainder = 0;

            numberOfMultiples = columnNumber / 26;
            Console.WriteLine(numberOfMultiples);


            // int lenghtOfAlphabetColumnId = 1;
            // bool flag = true;
            // while(flag)
            // {
            //     if((columnNumber - 26) > 0)
            //     {
            //         columnNumber -= 26;
            //         lenghtOfAlphabetColumnId++;
            //     }
            //     else
            //     {
            //         flag = false;
            //     }
            // }
            // Console.WriteLine(lenghtOfAlphabetColumnId);
            // return _alphabetList[columnNumber].ToString();
            return "";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(getAlphabetColumnId(52));
        }
    }
}

