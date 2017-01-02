/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/palindrome-index
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_index
{
    class Program
    {
        static void Main(string[] args)
        {
            /*********************************************************/
            const int DEBUGHIGH = 3;
            const int DEBUGLOW = 2;
            const int DEBUGOFF = 1;
            int localdebug = DEBUGOFF;
            bool localinput = false;
            string inputFile = "input1.txt";
            /*********************************************************/
            List<string> lines = new List<string>();
            int currentLine = 0;
            if (!localinput)
            {
                string tmpLine = "";
                int lineIndex = 0;
                while ((tmpLine = Console.ReadLine()) != null)
                {
                    lines.Insert(lineIndex++, tmpLine);
                }
            }
            else
            {
                string[] tmpLines = System.IO.File.ReadAllLines(inputFile);
                lines = new List<string>(tmpLines);
            }
            /*********************************************************/



            int arraySize = Convert.ToInt32(lines[currentLine++]);


            for(int i = 0; i < arraySize; i++) { 

                char[] theArray = lines[currentLine++].ToCharArray();
                int[] replaceArray = checkPalindrome(theArray,0,theArray.Length-1);
                int replaceAnswer = -1;


                if (replaceArray != null)
                {
                    int s1 = replaceArray[0]+1;
                    int e1 = replaceArray[1];

                    int s2 = replaceArray[0];
                    int e2 = replaceArray[1]-1;

                    int r1 = replaceArray[0];
                    int r2 = replaceArray[1];


                    if (checkPalindrome(theArray, s1,e1) == null)
                    {
                        replaceAnswer = r1;
                    }
                    else if(checkPalindrome(theArray, s2, e2) == null)
                    {
                        replaceAnswer = r2;
                    }
                }

                Console.WriteLine(replaceAnswer);

                if (localdebug > DEBUGOFF)
                {
                    Console.ReadKey();
                }
            }

        }


        static int[] checkPalindrome(char[] theArray,int startIndex,int endIndex)
        {
            int[] returnArray = new int[2];
            int z = endIndex;


            for (int i = startIndex; i < z; i++,z--)
            {
                if (theArray[i] != theArray[z])
                {
                    returnArray[0] = i;
                    returnArray[1] = z;
                    return returnArray;
                }
                else
                {
                    
                }
            }

            return null;
        }

    }
}
