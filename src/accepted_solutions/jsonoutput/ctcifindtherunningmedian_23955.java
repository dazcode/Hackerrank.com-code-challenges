/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-find-the-running-median
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
        int n = in.nextInt();
        int a[] = new int[n];
        
        PriorityQueue<Integer> minHeap=new PriorityQueue<Integer>();
        PriorityQueue<Integer> maxHeap=new PriorityQueue<Integer>(10,Collections.reverseOrder());
    
       
        
        for(int a_i=0; a_i < n; a_i++){
            System.out.println(calculateMedian(in.nextInt(),minHeap,maxHeap));
        }
    }

    
        
    
    public static double calculateMedian(int theNumber,PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap){
       
        addNumberToBag(theNumber,minHeap,maxHeap);
        rebalanceBags(minHeap,maxHeap);
        return getMedian(minHeap,maxHeap);
        
    }
    
    public static void addNumberToBag(int theNumber,PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap){
        
        int minVal;
        if(minHeap.size()>0){
            minVal=minHeap.peek();
            if(theNumber>=minVal){
            minHeap.add(theNumber);
            }
            else{
                maxHeap.add(theNumber);
            }
        }
        else{
            minHeap.add(theNumber);
        }
        
        
    
    }
    
    public static void rebalanceBags(PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap){
        
        int minHeapSize=minHeap.size();
        int maxHeapSize=maxHeap.size();
        
        PriorityQueue<Integer> more=minHeapSize>=maxHeapSize?minHeap:maxHeap;
        PriorityQueue<Integer> less=minHeapSize>=maxHeapSize?maxHeap:minHeap;
        
        if(Math.abs(minHeapSize-maxHeapSize)>1){
            less.add(more.poll());
        }
    
    }
    
    public static double getMedian(PriorityQueue<Integer> minHeap,PriorityQueue<Integer> maxHeap){
    
        int minHeapSize=minHeap.size();
        int maxHeapSize=maxHeap.size();
        
        if(minHeapSize==0){
            return maxHeap.peek();
        }
        else if(maxHeapSize==0){
            return minHeap.peek();
        }
            
            
        int minHeapValue=minHeap.peek();
        int maxHeapValue=maxHeap.peek();
        
        if(minHeapSize==maxHeapSize){
            return ((double)(minHeapValue+maxHeapValue)/2);
        }
        else if(minHeapSize>maxHeapSize){
            return minHeapValue;
        }
        else{
            return maxHeapValue;
        }
    
    }
    
}
