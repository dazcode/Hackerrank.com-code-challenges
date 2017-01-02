/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-review-loop
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace review
{
    class Program
    {
        static void Main(string[] args)
        {

            int testCases = Convert.ToInt32(Console.ReadLine());


            string currentLine = "";

            string evenString = "";
            string oddString = "";


            while ((currentLine = Console.ReadLine()) != null)
            {
                Char[] currentCharArray = currentLine.ToCharArray();
                evenString="";
                oddString="";
                for (int i = 0; i < currentCharArray.Count(); i++)
                {

                    if (i % 2 == 0)
                    {
                        evenString += currentCharArray[i];
                        
                    }
                    else
                    {
                        oddString += currentCharArray[i];
                       
                    }
                }
                Console.WriteLine(evenString+ " "+oddString );
    }
    

        }
    }
}
