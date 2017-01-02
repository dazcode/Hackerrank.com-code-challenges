/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/mini-max-sum
this code may need to run in the hackerrank online ide to work correctly
*****************************/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;

public class Solution {

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        long[] arrayInput=new long[5];
        
        long theSum=0;
        long biggest=Long.MIN_VALUE;
        long smallest=Long.MAX_VALUE;
        
        for(int i=0;i<arrayInput.length;i++){
            arrayInput[i] = in.nextLong();
            theSum+=arrayInput[i];
            if(arrayInput[i]>biggest){
                biggest=arrayInput[i];
            }
            if(arrayInput[i]<smallest){
                smallest=arrayInput[i];
            }
            
        }
        long outputSmall=theSum-biggest;
        long outputBiggest=theSum-smallest;
        System.out.print(outputSmall+" "+outputBiggest);
        
        
        
        
        
    }
}
