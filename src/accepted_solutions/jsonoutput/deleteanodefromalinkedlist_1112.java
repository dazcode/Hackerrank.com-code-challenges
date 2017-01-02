/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/delete-a-node-from-a-linked-list
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
  Delete Node at a given position in a linked list 
  head pointer input could be NULL as well for empty list
  Node is defined as 
  class Node {
     int data;
     Node next;
  }
*/
    // This is a "method-only" submission. 
    // You only need to complete this method. 

Node Delete(Node head, int position) {
  // Complete this method
    
    if(head==null){
        return null;
    }
    
    Node currentNode=head;
    int currentPosition=0;  
    
    while(currentPosition<position-1){
        currentNode=currentNode.next;
        currentPosition++;
    }   
    
    if(position==0){
        return currentNode.next;
    }
    
    if(currentNode.next!=null){
        currentNode.next=currentNode.next.next;
    }
   
    return head;

}

