/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-ransom-note
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_m = Console.ReadLine().Split(' ');
        int m = Convert.ToInt32(tokens_m[0]);
        int n = Convert.ToInt32(tokens_m[1]);
        string[] magazine = Console.ReadLine().Split(' ');
        string[] ransom = Console.ReadLine().Split(' ');
        
        
        //check the intersection of ransom and magazine and print yes
        //put magazine in hashtable
        //loop ransom and see if items exist in hash table
        
        Dictionary<string,int> magazineHashTable=new Dictionary<string,int>();
        
        for(int i=0;i<magazine.Length;i++){
            string currentKey=magazine[i];
            if(magazineHashTable.ContainsKey(currentKey)){
                magazineHashTable[currentKey]++;
            }
            else{
                magazineHashTable.Add(currentKey,1);
            }
        }
        
        Boolean success=true;
        for(int i=0;i<ransom.Length;i++){
            string currentKey=ransom[i];
            if(magazineHashTable.ContainsKey(currentKey)){
                magazineHashTable[currentKey]--;
                if(magazineHashTable[currentKey]<1){
                    magazineHashTable.Remove(currentKey);
                }
            }
            else{
                success=false;
            }
        }
        
        
        if(success){
            Console.WriteLine("Yes");
        }
        else{
            Console.WriteLine("No");
        }
        
    }
}
