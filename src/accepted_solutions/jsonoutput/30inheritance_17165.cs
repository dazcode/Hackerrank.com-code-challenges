/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-inheritance
this code may need to run in the hackerrank online ide to work correctly
*****************************/
class Student : Person{
    private int[] testScores;  
  
    public Student(string firstName,string lastName, int identification,int[] scores){
        this.firstName=firstName;
        this.lastName=lastName;
        this.id=identification;
        this.testScores=scores;
    }
    
    public char calculate(){
        int tempScore=0;
        char grade=' ';
        
        for(int i=0;i<this.testScores.Length;i++){
            tempScore+=testScores[i];
        }
        float average=tempScore/this.testScores.Length;
        if(average>=90){
            grade='O';
        }
        else if(average>=80){
            grade='E';
        }
        else if(average>=70){
            grade='A';
        }
        else if(average>=55){
            grade='P';
        }
        else if(average>=40){
            grade='D';
        }
        else if(average<40){
            grade='T';
        }
        
        return grade;
    }
}