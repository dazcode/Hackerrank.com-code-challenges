/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-dictionaries-and-maps
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary_maps
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Dictionary<string,int> phoneList = new Dictionary<string,int>();

            string outputString = "";
            string currentLine = "";

            Console.ReadLine();
            while ((currentLine = Console.ReadLine()) != null) {


                outputString = "";
                string[] parsedLine = currentLine.Split(' ');
                if (parsedLine.Count() > 1)
                {
                    phoneList.Add(parsedLine[0], Convert.ToInt32(parsedLine[1]));
                }
                else
                {
                    string searchName = parsedLine[0];
                    if (phoneList.ContainsKey(searchName)) {
                        outputString += searchName+"="+ phoneList[searchName];
                    }
                    else
                    {
                        outputString += "Not found";
                    }
                    Console.WriteLine(outputString);
                }
            }
        }
    }
}
