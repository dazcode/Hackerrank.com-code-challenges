/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-generics
this code may need to run in the hackerrank online ide to work correctly
*****************************/
 static void printArray<T>(T[] type)
        {
            for(int i = 0; i < type.Length; i++)
            {
                Console.WriteLine(type[i].ToString());
            }
        }