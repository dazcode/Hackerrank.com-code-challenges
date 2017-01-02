/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list-in-reverse
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
  Insert Node at the end of a linked list 
  head pointer input could be NULL as well for empty list
  Node is defined as 
  class Node {
     int data;
     Node next;
  }
*/
    // This is a "method-only" submission. 
    // You only need to complete this method. 

void ReversePrint(Node head) {
  
    Stack<Integer> theStack=new Stack<Integer>();
    
    while(head!=null){
        theStack.push(head.data);
        head=head.next;
    }
    
    
    while(!theStack.isEmpty()){
        int currentInt=theStack.pop();
        System.out.println(currentInt);
    }
}
