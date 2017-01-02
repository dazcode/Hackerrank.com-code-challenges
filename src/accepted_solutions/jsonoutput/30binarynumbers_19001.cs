/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-binary-numbers
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputInt = Convert.ToInt32(Console.ReadLine());
            char[] result = binaryConvert(inputInt);
            

            int score = 0;
            int highScore = 0;
            for(int i = 0; i < result.Count();i++)
            {
                if (result[i] == '1')
                {
                    score++;
                    if (score > highScore)
                    {
                        highScore = score;
                    }
                }
                else
                {
                    score = 0;
                }
            }
            //Console.WriteLine(result);
            //Console.WriteLine("score:" + highScore);
            //Console.ReadKey();
            Console.WriteLine(highScore);

        }

        static char[] binaryConvert(int theNumber)
        {
            
            char[] binaryString = new char[getHighestBase2(theNumber)+1];
            int breakLoop = 0;
            while (theNumber > 0)
            {
                int tmpNumber = getHighestBase2(theNumber);
                theNumber -= (int)Math.Pow(2, tmpNumber);
                binaryString[tmpNumber] = '1';

                if (breakLoop > 10000)
                {
                    break;
                }
                breakLoop++;
            }

            return binaryString;
        }

        static int getHighestBase2(int theNumber)
        {
            return (int)Math.Log(theNumber, 2);
        }
    }
}
