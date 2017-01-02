/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/insertionsort1
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertionsort_part1
{
    class Program
    {
        static void Main(string[] args)
        {

            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] unsortedIntArray = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            //int arraySize = 10;
            //int[] unsortedIntArray = new int[] { 2, 3 ,4, 5 ,6, 7, 8, 9, 10, 1 };

            int unsortedNumber = unsortedIntArray[arraySize - 1];
            bool endProgram = false;
            

            for (int i = arraySize - 1; i >= 0; i--)
            {
                string outputLine = "";

                if (i - 1 >= 0)
                {
                    unsortedIntArray[i] = unsortedIntArray[i - 1]; 
                }

                if ((unsortedIntArray[i] < unsortedNumber))
                {
                    unsortedIntArray[i] = unsortedNumber;
                    endProgram = true;
                }
                else if (i == 0)
                {
                    unsortedIntArray[i] = unsortedNumber;
                }


                for (int y = 0; y < arraySize; y++)
                {
                    outputLine += (unsortedIntArray[y].ToString());
                    if (y < arraySize - 1)
                    {
                        outputLine += " ";
                    }
                }

                Console.WriteLine(outputLine);
                if (endProgram)
                {
                    break;
                }
                

            }

            Console.ReadKey();


        }
    }
}
