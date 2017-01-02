/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-abstract-classes
this code may need to run in the hackerrank online ide to work correctly
*****************************/
//Write MyBook class
class MyBook : Book{
      override public void  display(){
        Console.WriteLine("Title: "+this.title);
        Console.WriteLine("Author: "+this.author);
        Console.WriteLine("Price: "+this.price);
    }
    
    protected int price;
    
    public MyBook(string title,string author,int price):base(title,author){
        this.author=author;
        this.title=title;
        this.price=price;
    }
}
