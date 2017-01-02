/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/quicksort3
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quicksort_in_place
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
            string inputFile = "input2.txt";
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


            quicksort(theArray,0,theArray.Length-1);

            
            if (localdebug > DEBUGOFF)
            {
                Console.WriteLine("FINAL ANSWER:" + String.Join(" ", theArray));
                Console.ReadKey();
            }

        }


        static void quicksort(int[] arrayToSort,int startIndex,int endIndex)
        {
            int thePivot = endIndex;
            int lowIndex = startIndex;
            int tmpValue = 0;

            for (int i = startIndex; i < endIndex; i++)
            {
                //Console.WriteLine("arrayToSort["+i+"]:" + arrayToSort[i]);
                
                if (arrayToSort[i] < arrayToSort[thePivot])
                {
                    tmpValue = arrayToSort[i];
                    arrayToSort[i] = arrayToSort[lowIndex];
                    arrayToSort[lowIndex] = tmpValue;
                    lowIndex++;
                }
            }

            tmpValue = arrayToSort[lowIndex];
            arrayToSort[lowIndex] = arrayToSort[thePivot];
            arrayToSort[thePivot] = tmpValue;

            

            int s1 = startIndex;
            int e1 = lowIndex - 1;
            int s2 = lowIndex + 1;
            int e2 = endIndex;

            /*
            Console.WriteLine("s1:" + s1);
            Console.WriteLine("e1:" + e1);
            Console.WriteLine("s2:" + s2);
            Console.WriteLine("e1:" + e2);
            */
            Console.WriteLine(String.Join(" ", arrayToSort));

            if ((e1 - s1) > 0)
            {
                quicksort(arrayToSort, s1, e1);
            }
            if((e2 - s2) > 0)
            {
                quicksort(arrayToSort, s2, e2);
            }


           


        }



    }
}
