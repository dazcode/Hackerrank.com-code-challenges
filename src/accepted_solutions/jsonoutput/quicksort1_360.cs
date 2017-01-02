/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/quicksort1
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort1
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
            int[] theArray = Array.ConvertAll(lines[currentLine++].Split(' '), int.Parse);
            arraySize = theArray.Count();


            int pivot = theArray[0];
            List<int> lowArray = new List<int>();
            List<int> equalArray = new List<int>();
            List<int> highArray = new List<int>();

            for (int i = 0; i < arraySize; i++)
            {
                if (theArray[i] > pivot)
                {
                    highArray.Add(theArray[i]);
                }
                else if (theArray[i] == pivot)
                {
                    equalArray.Add(theArray[i]);
                }
                else
                {
                    lowArray.Add(theArray[i]);
                }
            }

            lowArray.AddRange(equalArray);
            lowArray.AddRange(highArray);


            Console.WriteLine(String.Join(" ",lowArray.ToArray()));

            if (localdebug > DEBUGOFF)
            {
                Console.ReadKey();
            }


            //get low array and high array
            //loop low and loop high and shift according to pivot











        }
    }
}
