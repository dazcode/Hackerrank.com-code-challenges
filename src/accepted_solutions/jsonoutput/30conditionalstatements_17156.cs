/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-conditional-statements
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(String[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());


            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if(N>=2 && N<=5)
            {
                Console.WriteLine("Not Weird");
            }
            else if(N>=6 && N<= 20)
            {
                Console.WriteLine("Weird");
            }
            else if (N > 20)
            {
                Console.WriteLine("Not Weird");
            }

        }


    }
}

