/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-comparator-sorting
this code may need to run in the hackerrank online ide to work correctly
*****************************/
// Write your Checker class here

class Checker implements Comparator<Player>{
    
    @Override
    public int compare(Player a1,Player b1){
        
        Player a=(Player)a1;
        Player b=(Player)b1;
        
        if(a.score>b.score){
            return -1;
        }
        else if(b.score>a.score){
            return 1;   
        }
        else{
            return a.name.compareTo(b.name);
        }
        
    }
    
}