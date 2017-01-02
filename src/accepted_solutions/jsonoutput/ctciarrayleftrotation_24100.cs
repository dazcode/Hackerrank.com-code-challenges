/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-array-left-rotation
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rotation
{
    class Dazcode
    {
        /*********************************************************/
        public const int DEBUGHIGH = 3;
        public const int DEBUGLOW = 2;
        public const int DEBUGOFF = 1;
        public int localdebug = DEBUGOFF;
        public bool localinput = false;
        public string inputFile = "input1.txt";

        /*********************************************************/
        private int currentLine = 0;
        List<string> lines = new List<string>();

        public Dazcode()
        {
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
        }

        public void WriteLine(string input, bool debug)
        {
            if (debug)
            {
                if (this.localdebug > DEBUGOFF)
                {
                    Console.WriteLine(input);
                }
            }
            else
            {
                Console.WriteLine(input);
            }
        }
        public string getNextString()
        {
            return lines[currentLine++];
        }
        public void pauseIfDebug()
        {
            if (localdebug > DEBUGOFF)
            {
                Console.ReadKey();
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Dazcode dazcode = new Dazcode();


            int[] input1 = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);
            int arraySize = input1[0];
            int leftRotate = input1[1];

            int[] a = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);
            int[] rotatedArray = new int[a.Length];


            for(int i = 0; i < arraySize; i++) { 
                int swapIndex = GetSwapLocation(i, arraySize, leftRotate);
                rotatedArray[swapIndex] = a[i];
            }


            Console.WriteLine(String.Join(" ", rotatedArray));
            dazcode.pauseIfDebug();
        }   

            static int GetSwapLocation(int currentIndex, int theArraySize, int leftShiftNumber)
            {
            
                int offsetIndex = 0;
                offsetIndex = ((currentIndex - leftShiftNumber) % theArraySize);
                offsetIndex += theArraySize;
                offsetIndex %= theArraySize;

                return offsetIndex;


            }

        
    }
}
