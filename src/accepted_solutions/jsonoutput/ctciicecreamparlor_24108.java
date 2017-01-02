/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-ice-cream-parlor
this code may need to run in the hackerrank online ide to work correctly
*****************************/
import java.io.*;
import java.util.*;
import java.text.*;
import java.math.*;
import java.util.regex.*;


public class Solution {
   
    

    public static void main(String[] args) {
        
        int t;
        int n, m;
 
        Scanner in = new Scanner(System.in);
        t = in.nextInt();
       for(int test = 0; test < t; test++) {       
            
            m = in.nextInt();
            n = in.nextInt(); 
            Integer[] arr = new Integer[n];
    
            for (int i = 0; i < n; i++){
                arr[i] = in.nextInt();
            }
           
            findComplements(arr,m);
            
            
        }
        
    }
                        



public static void findComplements(Integer[] theArray,int totalMoney){

    HashMap<Integer,Integer> complementHash=new HashMap<Integer,Integer>();
    for(Integer i=0;i<theArray.length;i++){
    
        Integer currentValue=theArray[i];
        Integer complementValue=totalMoney-currentValue;
        
        if(complementHash.containsKey(complementValue)){
            
            Integer number1=complementHash.get(complementValue)+1;
            Integer number2=i+1;
            
            if(number2>=number1){
                System.out.println(number1+" "+number2);
            }
            else{
                System.out.println(number2+" "+number1);
            }
            return;
        }
        else{
            if(!complementHash.containsKey(theArray[i])){
                complementHash.put(theArray[i],i);
            }
        }
    }

}
}