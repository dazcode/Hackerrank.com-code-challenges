/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-loops
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {

            int multipleNumber = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < 11; i++)
            {
                int product = i * multipleNumber;
                string outputString = multipleNumber+" x "+i+" = "+product;
                Console.WriteLine(outputString);
            }
        }
    }
}
