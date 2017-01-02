/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-recursion
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {

            int inputNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(factorial(inputNumber));
        }

        static int factorial(int theNumber)
        {
            if (theNumber > 0)
            {
                return theNumber * (factorial(theNumber - 1));
            }
            else
            {
                return 1;
            }
        }
    }
}
