/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-connected-cell-in-a-grid
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
        int m = in.nextInt();
        int grid[][] = new int[n][m];
        for(int grid_i=0; grid_i < n; grid_i++){
            for(int grid_j=0; grid_j < m; grid_j++){
                grid[grid_i][grid_j] = in.nextInt();
            }
        }
        printLargestRegion(grid, n,m);
    }
    
    
    
    

public static void printLargestRegion(int[][] theArray, int n, int m){

    int topRegionScore=0;
    
    
        for(int column=0;column<m;column++){
            int[][] tmpVisitedArray=new int[n][m];
    
        for(int row=0;row<n;row++){
            int tmpScore=runDFS(theArray,tmpVisitedArray,column,row,n,m);
            
            if(tmpScore>topRegionScore){
                topRegionScore=tmpScore;
            }
            
        }
    }
   
    System.out.println(topRegionScore);
}


public static int runDFS(int[][] theArray,int[][] tmpVisitedArray,int column,int row,int n,int m){

    int count=0;

    if(column>n-1 || column<0 || row>m-1 || row<0){
        return count;
    }
    
    
    //System.out.println(n+", column:"+column+",row:"+row);
   
    if(tmpVisitedArray[column][row]==1){
        return 0;
    }
    else{
        tmpVisitedArray[column][row]=1;
    }
    // check 8 total adjacent records;
    if(theArray[column][row]==0){
        
    }
    else{
        count++;
        count+=runDFS(theArray,tmpVisitedArray,column-1,row-1,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column,row-1,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column+1,row-1,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column-1,row,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column+1,row,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column-1,row+1,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column,row+1,n,m);
        count+=runDFS(theArray,tmpVisitedArray,column+1,row+1,n,m);
    }
    
    
    return count;

}
    
    
    
    
    
}
