/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/arrays-ds
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        //int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

        for (int i = arr_temp.Count() - 1; i >= 0; i--)
        {
            System.Console.Write(arr_temp[i] + " ");
        }

    }
}
