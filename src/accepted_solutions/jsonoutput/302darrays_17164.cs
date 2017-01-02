/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-2d-arrays
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix_hourglass {
    class Program
    {
        static void Main(string[] args)
        {
            //int testCases = Convert.ToInt32(Console.ReadLine());
            int testCases = 1;

            for (int runCases = 0; runCases < testCases; runCases++)
            {
                int[,] searchArea = null;
                int? searchAreaHeight=null;
                int? searchAreaWidth=null;
                
                string currentLine = "";
                int loopY = 0;

                while((currentLine = Console.ReadLine())!=null)
                {
                    int[] currentArray=Array.ConvertAll(currentLine.Split(' '), int.Parse);
                    if (!searchAreaHeight.HasValue)
                    {
                        searchAreaHeight = currentArray.Count();
                        searchAreaWidth = currentArray.Count();
                        searchArea = new int[searchAreaWidth.Value, searchAreaHeight.Value];
                    }
                    for (int loopX = 0; loopX < currentArray.Count(); loopX++)
                    {
                        searchArea[loopY, loopX] = currentArray[loopX];
                    }

                    loopY++;
                }
                
               

                
                


                /*
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
                */

                int patternHeight = 3;
                int patternWidth = 3;
                bool[,] patternToMatch = new bool[patternHeight, patternWidth];
                patternToMatch[0, 0] = true;
                patternToMatch[0, 1] = true;
                patternToMatch[0, 2] = true;

                patternToMatch[1, 0] = false;
                patternToMatch[1, 1 ] = true;
                patternToMatch[1, 2] = false;

                patternToMatch[2, 0] = true;
                patternToMatch[2, 1] = true;
                patternToMatch[2, 2] = true;



                int tempSum = 0;
                int? highSum=null;

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

                        //check the pattern
                        for (int y = 0; y < patternHeight; y++)
                        {
                            for (int x = 0; x < patternWidth; x++)
                            {
                                int indexTempX = x + arr_x;
                                int indexTempY = y + arr_y;

                                if (!(patternToMatch[y, x]))
                                {
                                    continue;
                                }
                                else
                                {
                                    tempSum +=searchArea[indexTempY, indexTempX];
                                }
                            }

                            
                        }

                        if (!highSum.HasValue || tempSum > highSum)
                        {
                            highSum = tempSum;
                        }


                    }
                }

                Console.WriteLine(highSum.Value);
                /*
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
                */

            }
        }

    }
}