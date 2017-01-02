/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/insert-a-node-at-the-head-of-a-linked-list
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
  Insert Node at the beginning of a linked list 
  head pointer input could be NULL as well for empty list
  Node is defined as 
  class Node {
     int data;
     Node next;
  }
*/
// This is a "method-only" submission. 
// You only need to complete this method. 

Node Insert(Node head,int x) {
    
    Node newNode=new Node();
    newNode.data=x;
    
    newNode.next=head;
    
    return newNode;
    
}
