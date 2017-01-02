/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-arrays
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();

            int[] arrayInt = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int[] arrayIntReversed = new int[arrayInt.Count()];

            
            for(int i=arrayInt.Count()-1;i>=0;i--)
            {
                
                Console.Write(arrayInt[i]);

                if (i != 0)
                {
                    Console.Write(" ");
                }
            }

        }

    }
}
