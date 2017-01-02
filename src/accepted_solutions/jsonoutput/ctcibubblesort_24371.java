/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-bubble-sort
this code may need to run in the hackerrank online ide to work correctly
*****************************/
import java.io.*;
import java.util.*;

public class Solution {

    
    public static void main(String[] args) {
    
        int[] arrayToSort=new int[10];
        
        
        Solution thisTest=new Solution();
        
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        int a[] = new int[n];
        for(int a_i=0; a_i < n; a_i++){
            a[a_i] = in.nextInt();
        }
        thisTest.processBubbleSort(a);
        
    }
    
    public void processBubbleSort(int[] arrayToSort){
    
        int numberSwaps=0;
        int firstElement=0;
        int lastElement=0;
        
        int swapVal=0;
        
        int lastLoop=arrayToSort.length;
        
        for(int i=0;i<lastLoop;i++){
                for(int x=0;x<lastLoop-1;x++){
                   
                    //System.out.println("First Int: "+arrayToSort[x]+ " last integer."+arrayToSort[x+1]);
                    if(arrayToSort[x]>arrayToSort[x+1]){
                        
                        swapVal=arrayToSort[x];
                        arrayToSort[x]=arrayToSort[x+1];
                        arrayToSort[x+1]=swapVal;
                        
                        
                        numberSwaps++;
                    }
                }
        }
        
        firstElement=arrayToSort[0];
        lastElement=arrayToSort[arrayToSort.length-1];
        
        printData(numberSwaps,firstElement,lastElement);
    }
    
    
    public void printData(int numberSwaps,int firstElement,int lastElement){
    
        System.out.println("Array is sorted in "+ numberSwaps + " swaps.");
        System.out.println("First Element: "+ firstElement);
        System.out.println("Last Element: "+ lastElement);
        
    }
    
    

}