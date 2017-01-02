/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/2d-array
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {

        bool useManualInput = false;

        string[] testInputString= new string[6];

        testInputString[0] = "1 1 1 0 0 0";
        testInputString[1] = "0 1 0 0 0 0";
        testInputString[2] = "1 1 1 0 0 0";
        testInputString[3] = "0 0 2 4 4 0";
        testInputString[4] = "0 0 0 2 0 0";
        testInputString[5] = "0 0 1 2 4 0";




        bool[,] patternToMatch = new bool[3, 3];
        int[][] searchArea = new int[6][];

        patternToMatch[0, 0] = true;
        patternToMatch[0, 1] = true;
        patternToMatch[0, 2] = true;

        patternToMatch[1, 0] = false;
        patternToMatch[1, 1] = true;
        patternToMatch[1, 2] = false;

        patternToMatch[2, 0] = true;
        patternToMatch[2, 1] = true;
        patternToMatch[2, 2] = true;

        int searchAreaWidth = 6;
        int searchAreaHeight = 6;
        int patternHeight = 3;
        int patternWidth = 3;


        string inputLine = "";
        string[] arr_tempStr;
        int[] arr_tempInt;
        int currentLine = 0;

        int tmpSum = 0;
        int? highSum = null;

        if (useManualInput)
        {

            for(int tmpInt=0; tmpInt<testInputString.Count(); tmpInt++)
            {
                    arr_tempStr = testInputString[tmpInt].Split(' ');
                    arr_tempInt = Array.ConvertAll(arr_tempStr, Int32.Parse);
                    searchArea[tmpInt] = arr_tempInt;
            }

        }
        else
        {

            while ((inputLine = Console.ReadLine()) != null)
            {
                arr_tempStr = inputLine.Split(' ');
                arr_tempInt = Array.ConvertAll(arr_tempStr, Int32.Parse);
                searchArea[currentLine] = arr_tempInt;

                currentLine++;
                if (currentLine > 10)
                {
                    break;
                }
            }

        }

        


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


                tmpSum = 0;

                //check the pattern
                for (int y = 0; y < patternHeight; y++)
                {
                    for (int x = 0; x < patternWidth; x++)
                    {

                        int indexTempX = x + arr_x;
                        int indexTempY = y + arr_y;

                        if (patternToMatch[y, x])
                        {
                            tmpSum += searchArea[indexTempY][indexTempX];
                        }
                    }

                    
                }

                if (highSum == null || tmpSum > highSum)
                {
                    highSum = tmpSum;
                }

            }


        }

        Console.WriteLine(highSum.ToString());
        Console.ReadLine();

    }
}