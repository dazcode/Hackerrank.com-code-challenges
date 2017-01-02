/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/compare-the-triplets
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comparetriplets
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
            int[] input2 = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);

            int scoreA = 0;
            int scoreB = 0;

            for(int i = 0; i < 3; i++)
            {
                if (input1[i] > input2[i])
                {
                    scoreA++;
                }
                else if(input1[i] < input2[i])
                {
                    scoreB++;
                }
            }
            

            Console.WriteLine(scoreA + " " + scoreB);
            dazcode.pauseIfDebug();
        }
    }
}
