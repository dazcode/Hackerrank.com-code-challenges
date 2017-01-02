/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/sherlock-and-valid-string
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sherlock_valid_string
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


            char[] charArray = lines[currentLine++].ToCharArray();
            Dictionary<char, int> theHash = new Dictionary<char, int>();
            Dictionary<int, int> theFrequency = new Dictionary<int, int>();
            bool hasFailed = false;

            for (int i = 0; i < charArray.Length; i++)
            {
                if (theHash.ContainsKey(charArray[i]))
                {
                    theHash[charArray[i]]++;
                }
                else
                {
                    theHash[charArray[i]] = 1;
                }
            }

            
            foreach (KeyValuePair<char, int> item in theHash)
            {
                if (theFrequency.ContainsKey(item.Value))
                {
                    theFrequency[item.Value] ++;
                }
                else
                {
                    theFrequency[item.Value] = 1;
                }
            }


            if (theFrequency.Count > 2)
            {
                hasFailed = true;
            }

            if (!hasFailed) {
                int[] key = new int[2];
                int tmpIndex = 0;
                foreach (KeyValuePair<int, int> item in theFrequency)
                {
                    key[tmpIndex++] = item.Value;
                }
                if (key[0] > 1 && key[1] > 1)
                {
                    hasFailed = true;
                }

            }



            if (hasFailed)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }


            if (localdebug > DEBUGOFF)
            {
                Console.WriteLine("The Frequency:" + theFrequency.Count);
                Console.ReadKey();
            }



        }
    }
}
