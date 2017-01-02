/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-nested-logic
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day26nested
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] date1 = Console.ReadLine().Split(' ');
            string[] date2 = Console.ReadLine().Split(' ');

            DateTime returnedDate = DateTime.Parse(date1[1] + " " + date1[0] + " " + date1[2]);
            DateTime expectedDate = DateTime.Parse(date2[1] + " " + date2[0] + " " + date2[2]);

            int totalDays=(int)(returnedDate - expectedDate).TotalDays;
            
            // on or before
            int fineAmount;

            if (totalDays<=0)
            {
                fineAmount = 0;
            }
            else
            {
                if (returnedDate.Month == expectedDate.Month && returnedDate.Year == expectedDate.Year)
                {
                    fineAmount = (15 * totalDays);
                }
                else if(returnedDate.Year == expectedDate.Year)
                {
                    int monthsDiff = returnedDate.Month - expectedDate.Month;
                    fineAmount = (500*monthsDiff); 
                }
                else
                {
                    fineAmount = 10000;
                }
            }


            Console.WriteLine(fineAmount);


        }
    }
}
