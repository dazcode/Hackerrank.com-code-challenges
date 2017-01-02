/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tutorial-intro
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algorithms_sorting_into
{
    class Program
    {
        static void Main(string[] args)
        {

            int valueToFind = Convert.ToInt32(Console.ReadLine());
            int totalNumbers = Convert.ToInt32(Console.ReadLine());
            string numbersInput = Console.ReadLine();
            int[] numbersArray = Array.ConvertAll(numbersInput.Split(' '), int.Parse);


            for(int i=0; i < totalNumbers; i++)
            {
                if (numbersArray[i] == valueToFind)
                {
                    Console.WriteLine(i);
                }
            }




        }
    }
}
