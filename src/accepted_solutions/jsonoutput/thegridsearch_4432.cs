/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/the-grid-search
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternmatch_gridsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());


            for (int runCases = 0; runCases < testCases; runCases++)
            {



                int[] inputGridParams = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int searchAreaHeight = inputGridParams[0];
                int searchAreaWidth = inputGridParams[1];
                int[,] searchArea = new int[searchAreaHeight, searchAreaWidth];

                for (int x = 0; x < searchAreaHeight; x++)
                {
                    char[] charArray = Console.ReadLine().ToCharArray();
                    for (int y = 0; y < searchAreaWidth; y++)
                    {
                        searchArea[x, y] = Convert.ToInt32(charArray[y]);
                    }
                }



                int[] inputPatternParams = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

                int patternHeight = inputPatternParams[0];
                int patternWidth = inputPatternParams[1];
                int[,] patternToMatch = new int[patternHeight, patternWidth];

                for (int x = 0; x < patternHeight; x++)
                {
                    char[] charArray = Console.ReadLine().ToCharArray();
                    for (int y = 0; y < patternWidth; y++)
                    {
                        patternToMatch[x, y] = Convert.ToInt32(charArray[y]);
                    }
                }




                int tempSum = 0;
                int highSum = 0;

                for (int arr_y = 0; arr_y < searchAreaHeight; arr_y++)
                {
                    for (int arr_x = 0; arr_x < searchAreaWidth; arr_x++)
                    {

                        if (patternHeight + arr_y > searchAreaHeight)
                        {
                            break;
                        }
                        if (patternWidth + arr_x > searchAreaWidth)
                        {
                            continue;
                        }


                        tempSum = 0;
                        bool breakLoop = false;

                        //check the pattern
                        for (int y = 0; y < patternHeight; y++)
                        {
                            for (int x = 0; x < patternWidth; x++)
                            {
                                int indexTempX = x + arr_x;
                                int indexTempY = y + arr_y;

                                if (!(patternToMatch[y, x] == searchArea[indexTempY, indexTempX]))
                                {
                                    breakLoop = true;
                                    break;
                                }
                                else
                                {
                                    tempSum++;
                                }
                            }

                            if (breakLoop)
                            {
                                break;
                            }
                        }

                        if (tempSum > highSum)
                        {
                            highSum = tempSum;
                        }


                    }
                }
                if (highSum == (patternWidth * patternHeight))
                {
                    //Console.WriteLine("Pattern Matched!");
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
                //Console.WriteLine(highSum.ToString());
                

            }
        }

    }
}