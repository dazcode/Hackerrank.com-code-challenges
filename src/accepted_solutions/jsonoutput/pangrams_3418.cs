/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/pangrams
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pangram
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<char, bool> alphabet = new Dictionary<char,bool>();
            char[] alphabetChars=("abcdefghijklmnopqrstuvwxyz".ToCharArray());

            for (int x = 0; x < alphabetChars.Count(); x++) {
                alphabet.Add(alphabetChars[x], false);
            }

            string currentLine = "";

            while ((currentLine = Console.ReadLine()) != null)
            {
                char[] currentChars = currentLine.ToLower().ToCharArray();
                for (int i = 0; i < currentChars.Count(); i++)
                {
                    alphabet[currentChars[i]] = true;
                }
            }

            bool hasFailed = false;

            for (int x = 0; x < alphabetChars.Count(); x++)
            {
                if (!alphabet[alphabetChars[x]])
                {
                    hasFailed = true;
                    break;
                }
            }

            if (!hasFailed)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }

        }
    }
}
