/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/dynamic-array
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication2
{
    class Program
    {

        int lastAns = 0;
        int numSequence = 0;
        ArrayList baseArrayList = new ArrayList();



        static void Main(string[] args)
        {

            Program myProgram = new Program();
            string inputLine = Console.ReadLine();
            int[] inputArray = Array.ConvertAll(inputLine.Split(' '), Int32.Parse);
            myProgram.numSequence = inputArray[0];
            myProgram.runSequenceTest(inputArray);

        }


        void runSequenceTest(int[] inputArray)
        {
            for (int i = 0; i < numSequence; i++)
            {
                baseArrayList.Add(new ArrayList());
            }

            //Console.WriteLine("numSequence:" + numSequence + "baseArrayList:" + baseArrayList.Count.ToString());

            string currentLine = "";
            int queryCount = 0;


            while ((currentLine = Console.ReadLine()) != null)
            {
                int[] inputArrayData = Array.ConvertAll(currentLine.Split(' '), Int32.Parse);

                int queryType = inputArrayData[0];
                int numberX = inputArrayData[1];
                int numberY = inputArrayData[2];

                if (queryType==1) {
                    queryAddElement(numberX, numberY, baseArrayList);
                }
                else
                {
                    queryPrintElement(numberX, numberY, baseArrayList);
                }
                

                queryCount++;

            }
        }


        void queryAddElement(int queryX, int queryY, ArrayList theList)
        {
            int calcIndex = ((queryX ^ lastAns) % numSequence);
            //Console.WriteLine("calcIndex: " + calcIndex.ToString());
            //Console.WriteLine("queryAddElement: queryX:" + queryX.ToString()+" queryY:" + queryY.ToString()+" count:" + theList.Count.ToString());
            (baseArrayList[calcIndex] as ArrayList).Add(queryY);

        }


        void queryPrintElement(int queryX, int queryY, ArrayList theList)
        {
            int calcIndex = ((queryX ^ lastAns) % numSequence);
            //Console.WriteLine("calcIndex: " + calcIndex.ToString());
            //Console.WriteLine("queryPrintElement: queryX:" + queryX.ToString() + " queryY:" + queryY.ToString() + " count:" + theList.Count.ToString());


            int calcIndex2 = queryY % (baseArrayList[calcIndex] as ArrayList).Count;
            int? maybeNull =(baseArrayList[calcIndex] as ArrayList)[calcIndex2] as int?;
            lastAns = maybeNull.Value;

            Console.WriteLine(lastAns.ToString());
        }

    }
}
