/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/quicksort2
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

            List<int> arrayInput = new List<int>(theArray);

            List<int> sortedArray=partition(arrayInput);


            Console.WriteLine(String.Join(" ", sortedArray));

            if (localdebug > DEBUGOFF)
            {
                Console.ReadKey();
            }



        }

        static List<int> partition(List<int> theArray)
        {
            int arraySize = theArray.Count();

            int pivot = theArray[0];
            List<int> lowArray = new List<int>();
            List<int> equalArray = new List<int>();
            List<int> highArray = new List<int>();
            List<int> returnArray = new List<int>();


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


            if (checkPartition(lowArray))
            {
                lowArray = partition(lowArray);
                printArray(lowArray);
                returnArray.AddRange(lowArray);
            }
            else
            {
                returnArray = lowArray;
            }

            returnArray.AddRange(equalArray);

            if (checkPartition(highArray))
            {
                highArray = partition(highArray);
                printArray(highArray);
                returnArray.AddRange(highArray);
            }
            else
            {
                returnArray.AddRange(highArray);
            }

            return returnArray;
        }

        static bool checkPartition(List<int> arrayToPrint)
        {
            int arrayCount = arrayToPrint.Count();
            if (arrayCount <= 1)
            {
                return false;
            }
            else
            {

                return true;
            }
        }

        static void printArray(List<int> arrayToPrint)
        {
            Console.WriteLine(String.Join(" ", arrayToPrint));
        }

        
    }
}
