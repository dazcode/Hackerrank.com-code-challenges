/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-exceptions-string-to-integer
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(string[] args)
        {
            string theInput = Console.ReadLine();

            int tmpInt = 0;
            string outputString = "";

            try
            {
                tmpInt = Convert.ToInt32(theInput);
                outputString = tmpInt.ToString();
            }
            catch 
            {
                outputString = "Bad String";
            }

            Console.WriteLine(outputString);


        }
}
