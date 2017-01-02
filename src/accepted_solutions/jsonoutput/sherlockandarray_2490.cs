/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/sherlock-and-array
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sherlocksearchleftright
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
            int totalArrays = Convert.ToInt32(dazcode.getNextString());


            for (int x = 0; x < totalArrays; x++)
            {
                int arraySize = Convert.ToInt32(dazcode.getNextString());
                int[] inputArray = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);
                Boolean isEqual = false;
                int leftSum = 0;
                int rightSum = 0;

                for (int i = 0; i < inputArray.Length; i++)
                {
                    rightSum += inputArray[i];
                }


                int arrLength = inputArray.Length;
                if ((arrLength == 0 || arrLength == 1))
                {
                    isEqual = true;
                }
                else
                {

                    for (int i = 0; i < arrLength; i++)
                    {

                        int previousValue = i==0?0:inputArray[i-1];
                        int nextValue = inputArray[i];
                        leftSum += previousValue;
                        rightSum -= nextValue;

                        //Console.WriteLine("left:" + leftSum + ",right:" + rightSum);

                        if ((leftSum == rightSum))
                        {
                            isEqual = true;
                            break;
                        }
                    }

                }


                if (isEqual)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
            dazcode.pauseIfDebug();
        }
    }
}
