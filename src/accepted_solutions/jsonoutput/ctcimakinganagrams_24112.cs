/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-making-anagrams
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string a = Console.ReadLine();
        string b = Console.ReadLine();
        
        char[] arrayCharsA = a.ToCharArray();
        char[] arrayCharsB = b.ToCharArray();
        
        //get frequency of characters with hashmap
        //find the intersection 
        // 10 100 10 overlap
        // 10 100 3 overlap
        
        Dictionary<char,int> hashA = new Dictionary<char,int>();
        
        for(int i=0;i<arrayCharsA.Length;i++){
            char currentKey=arrayCharsA[i];
            if(!hashA.ContainsKey(currentKey)){
                hashA.Add(currentKey,1);
            }
            else{
                hashA[currentKey]++;
            }
        }
                
        int intersectionCount=0;
                
        for(int i=0;i<arrayCharsB.Length;i++){
            char currentKey=arrayCharsB[i];
            if(!hashA.ContainsKey(currentKey)){
                
            }
            else{
                hashA[currentKey]--;
                intersectionCount++;
                if(hashA[currentKey]<1){
                    hashA.Remove(currentKey);
                }
            }
        }

        int nonIntersection=(arrayCharsA.Length+arrayCharsB.Length)-(intersectionCount*2);
        
            
        Console.WriteLine(nonIntersection);
                
        
    }
}
