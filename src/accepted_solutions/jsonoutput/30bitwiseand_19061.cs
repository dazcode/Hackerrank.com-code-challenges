/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-bitwise-and
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day29bitwiseAND
{

    class Dazcode
    {
        /*********************************************************/
        public const int DEBUGHIGH = 3;
        public const int DEBUGLOW = 2;
        public const int DEBUGOFF = 1;
        public int localdebug = DEBUGOFF;
        public bool localinput = false;
        public string inputFile = "input2.txt";
        
        /*********************************************************/
        private int currentLine=0;
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

        public void WriteLine(string input,bool debug)
        {
            if(debug)
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



            /*
            int test1 = ~126;
            int test2 = (-1) * test1;
            int final = test1 & test2;
            
            //flip the rightmost bit
            int test1 = 126;
            int test2 = test1 | (test1 + 1);
            */
            
            //Console.WriteLine(test2);
            //Console.ReadKey(); 


            int testCases = Convert.ToInt32(dazcode.getNextString());
            for(int i = 0; i < testCases; i++)
            {
                int[] intArray = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);

                int numberN = intArray[0];
                int numberK = intArray[1];
                int answer = 0;
                
                //try to get low
                int lowA = numberK;
                int lowB = lowA - 1;
                int lowAnswer = lowA & lowB;

                if (lowAnswer == lowB)
                {
                    answer = lowAnswer;
                }
                else
                {
                    for (int x = (numberK-1); x > 0; x--)
                    {

                        //for highA we can be up to N-1
                        //flip the rightmost bit
                        int highA = x;
                        highA = highA | (highA + 1);

                        if (highA <= numberN) {
                            answer = x;
                            break;
                        }

                        if (x == 1)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(answer);
            }




            dazcode.pauseIfDebug();
        }



    }
    





}
