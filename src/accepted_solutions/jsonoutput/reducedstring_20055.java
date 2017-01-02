/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/reduced-string
this code may need to run in the hackerrank online ide to work correctly
*****************************/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;
import java.util.Scanner;


public class Solution {

    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        
        String s = input.next();
        
        if(s==null || s.length()==0 || s.length()==1){
            System.out.println(s);
            return;
        }
        
        char[] charArray=s.toCharArray();
        Stack<Character> theStack=new Stack<Character>();
        
        
        for(int i=0;i<charArray.length;i++){
            
            if(theStack.size()>0){
                char currentCharStack=theStack.pop();
                char currentFromCharString=charArray[i];

                if(currentCharStack!=currentFromCharString){
                    theStack.push(currentCharStack);
                    theStack.push(currentFromCharString);
                }
                else{
                    
                }
            }
            else{
                theStack.push(charArray[i]);
            }
            
            
        }
        String output="";
        int theStackSize=theStack.size();
        for(int i=0;i<theStackSize;i++){
            output+=theStack.remove(0);
        }
        if(output==""){
            output="Empty String";
        }
        
        System.out.println(output);
        
        
    }
}