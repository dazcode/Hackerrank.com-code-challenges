/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/fibonacci-modified
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace fibinocci_modified
{
    class Program
    {
        

        static void Main(string[] args)
        {

            

            //int[] input = { 0, 1, 5 };
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '),int.Parse);
            int a = input[0];
            int b = input[1];
            int n = input[2];
            BigInteger[] answers= new BigInteger[n+1];

            answers[0] = a;
            answers[1] = b;

            for(int i = 2; i < n; i++)
            {
                answers[i] = (answers[i - 1] * answers[i - 1]) + answers[i - 2];
            }

            Console.WriteLine(answers[n-1]);
            //Console.ReadKey();

        }

     
        

        

      
    }
}
