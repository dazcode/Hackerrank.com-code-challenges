/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-balanced-brackets
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Collections;

class Solution
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




    static void Main(string[] args)
    {
        Dazcode dazcode = new Dazcode();


        int[] input1 = Array.ConvertAll(dazcode.getNextString().Split(' '), int.Parse);
        int t = input1[0];

        for (int a0 = 0; a0 < t; a0++)
        {
            string expression = dazcode.getNextString();
            printResult(expression);

        }
        dazcode.pauseIfDebug();
    }


    static void printResult(String expression)
    {
        Boolean isWhatever = true;

        Char[] arrayChars = expression.ToCharArray();
        Stack<Char> myStack = new Stack<Char>();
        
        for (int i = 0; i < arrayChars.Length; i++)
        {
           

            Char currentChar = arrayChars[i];

            switch (currentChar)
            {
                case '{':
                case '[':
                case '(':
                    myStack.Push(currentChar);
                    break;
                case '}':
                    if (myStack.Count < 1)
                    {
                        isWhatever=false;
                        break;
                    }
                    isWhatever = (myStack.Pop() == '{');
                    break;
                case ']':
                    if (myStack.Count < 1)
                    {
                        isWhatever=false;
                        break;
                    }
                    isWhatever = (myStack.Pop() == '[');
                    break;
                case ')':
                    if (myStack.Count < 1)
                    {
                        isWhatever=false;
                        break;
                    }
                    isWhatever = (myStack.Pop() == '(');
                    break;
                
            }

            if (!isWhatever)
            {
                break;
            }
        }

        if (myStack.Count > 0)
        {
            isWhatever = false;
        }
        //push left open brackets on stack
        //if find right bracket pop off stack

        //if right bracket doesnt match then failure
        //if string is through and stack is greater than 0 then end

        if (isWhatever)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }

        
    }
}
