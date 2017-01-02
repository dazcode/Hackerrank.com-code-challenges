/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/sparse-arrays
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(String[] args)
        {
            
            string tmpString = "";
            int totalCount = 0;

            while ((tmpString = Console.ReadLine()) != null)
            {
                //Console.WriteLine("tmpString:" + tmpString);

                int numberofStrings = Convert.ToInt32(tmpString);
                string[] stringArray = new string[numberofStrings];

                //parse strings
                for (int i = 0; i < numberofStrings; i++)
                {
                    stringArray[i] = Console.ReadLine();
                    //Console.WriteLine("stringArray:" + stringArray[i]);
                }

                tmpString = Console.ReadLine();
                int numberofQueries = Convert.ToInt32(tmpString);
                string[] queriesArray = new string[numberofQueries];

                //parse queries
                for (int i = 0; i < numberofQueries; i++)
                {
                    queriesArray[i] = Console.ReadLine();
                    //Console.WriteLine("queriesArray:" + queriesArray[i]);
                }

                //pattern match queries

                for (int x = 0; x < numberofQueries; x++)
                {
                    totalCount = 0;
                    for (int i = 0; i < numberofStrings; i++)
                    {
                        //int textCount = new Regex(Regex.Escape(queriesArray[x])).Matches(stringArray[i]).Count;


                        if (stringArray[i] == queriesArray[x])
                        {
                            totalCount++;
                        }

                        //int textCount = new Regex(Regex.Escape(queriesArray[x])).Matches(stringArray[i]).Count;
                        //totalCount += textCount;
                    }
                    //Console.WriteLine("totalcount:" + totalCount.ToString());
                    Console.WriteLine(totalCount.ToString());
                }

                
            }

             
      }
    }
}
