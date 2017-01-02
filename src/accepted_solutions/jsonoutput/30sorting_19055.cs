/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-sorting
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day20sorting
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            int numberSwaps = 0;
            int currentSwaps = 0;

            numberSwaps = bubbleSort(a);

            string outputString = "Array is sorted in " + numberSwaps + " swaps.";
            Console.WriteLine(outputString);
            Console.WriteLine("First Element: "+a[0]);
            Console.WriteLine("Last Element: "+a[a.Count()-1]);


        }



        static int bubbleSort(int[] arrayToSort)
        {
            int numberOfSwaps = 0;

            for (int x = 0; x < arrayToSort.Count(); x++)
            {
                for (int y = 0; y < arrayToSort.Count() - 1; y++)
                {
                    if (arrayToSort[y] > arrayToSort[y+1])
                    {
                        int swapTemp = arrayToSort[y];
                        arrayToSort[y] = arrayToSort[y+1];
                        arrayToSort[y+1] = swapTemp;
                        numberOfSwaps++;
                    }
                }
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            return numberOfSwaps;
        }


    }

}