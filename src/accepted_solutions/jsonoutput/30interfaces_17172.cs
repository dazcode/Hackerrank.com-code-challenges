/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-interfaces
this code may need to run in the hackerrank online ide to work correctly
*****************************/
class Calculator:AdvancedArithmetic{
public int divisorSum(int n)
        {
            //int squareRoot = (int)Math.Sqrt(n);
            int sum = 0;
            for(int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
}