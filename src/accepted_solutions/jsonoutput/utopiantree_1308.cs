/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/utopian-tree
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace algorithms_utopiatree
{
    class Program
    {

        static void Main(String[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                int currentAge = 1;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                    {
                        currentAge *= 2;
                    }
                    else
                    {
                        currentAge++;
                    }
                }

                Console.WriteLine(currentAge.ToString());

            }


            

        }
    }

}
