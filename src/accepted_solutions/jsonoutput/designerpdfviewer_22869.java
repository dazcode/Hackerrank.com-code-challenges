/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/designer-pdf-viewer
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
        int n = 26;
        int h[] = new int[n];
        for(int h_i=0; h_i < n; h_i++){
            h[h_i] = in.nextInt();
        }
        String word = in.next();
        
        
        //h[0] to h[25] contains a-z height
        //width is number of chars
        
        char[] theCharArray=word.toCharArray();
        int maxHeight=0;
        int wordLength=theCharArray.length;
        
        for(int i=0;i<wordLength;i++){
            
            int currentHeight=getHeight(theCharArray[i],h);
            
            if(currentHeight>maxHeight){
                maxHeight=currentHeight;
            }
        }
         
        
        int wordArea=maxHeight*wordLength;
        System.out.println(wordArea);
        
        
    }
    
    public static int getHeight(char currentChar,int[] lengthArray){
        
        int charAscii=(int)currentChar;
        int offset=97;
        
        int currentLength = lengthArray[charAscii-offset];
        
      
        
        return currentLength;
        
    }
    
    
    
}
