/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/circular-array-rotation
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

            int[] inputArray = Array.ConvertAll(dazcode.getNextString().Split(' '),int.Parse);

            int arrayCount = inputArray[0];
            int numberShift = inputArray[1];
            int numberQueries = inputArray[2];

            int[] rotationArray = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);
            int theArraySize = rotationArray.Length;
            int[] rotatedArray = new int[theArraySize];

            if (numberShift > theArraySize)
            {
                numberShift =  numberShift%theArraySize;
            }

            Array.Copy(rotationArray, 0, rotatedArray, numberShift, theArraySize-numberShift);
            Array.Copy(rotationArray, theArraySize-numberShift, rotatedArray, 0, numberShift);

            for (int i = 0; i < numberQueries; i++)
            {
                int currentIndex = Convert.ToInt32(dazcode.getNextString());
                Console.WriteLine(rotatedArray[currentIndex]);
            }

            dazcode.pauseIfDebug();
        }
    }
}
