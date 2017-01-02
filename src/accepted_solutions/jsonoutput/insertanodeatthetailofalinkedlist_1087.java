/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/insert-a-node-at-the-tail-of-a-linked-list
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
Node Insert(Node head,int data) {
// This is a "method-only" submission. 
// You only need to complete this method.
    
    Node tailNode=new Node();
    tailNode.data=data;
    
    if(head==null){
        return tailNode;
    }
    else{
        Node currentNode=head;
        while(currentNode.next!=null){
            currentNode=currentNode.next;
        }
        
        currentNode.next=tailNode;
    }
    
    return head;
}
