/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-operators
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {


        static void Main(string[] args)
        {
            

            double mealCost = Convert.ToDouble(Console.ReadLine());
            double tipPercent = Convert.ToDouble(Console.ReadLine())/100;
            double taxPercent = Convert.ToDouble(Console.ReadLine())/100;
            int totalCost = 0;

            totalCost = (int)Math.Round((mealCost+(mealCost*taxPercent) + (mealCost*tipPercent)),0);
            
            Console.WriteLine("The total meal cost is "+ totalCost+ " dollars.");
        }

        


        }
}
