/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-more-exceptions
this code may need to run in the hackerrank online ide to work correctly
*****************************/
class Calculator
    {
 

        public int power(int var1,int var2)
        {
            string exceptionText = "n and p should be non-negative";

            if(var1<0 || var2<0) {
                throw new System.ArgumentException(exceptionText);
            }

            int result =(int) Math.Pow(var1, var2);

            return result;
        }
    }