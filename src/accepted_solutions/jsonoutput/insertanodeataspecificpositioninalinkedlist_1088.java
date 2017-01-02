/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/insert-a-node-at-a-specific-position-in-a-linked-list
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
  Insert Node at a given position in a linked list 
  head can be NULL 
  First element in the linked list is at position 0
  Node is defined as 
  class Node {
     int data;
     Node next;
  }
*/
    

Node InsertNth(Node head, int data, int position) {
   // This is a "method-only" submission. 
    // You only need to complete this method. \\
    
    Node newNode=new Node();
    newNode.data=data;
    
    int positionCounter=0;
    Node currentNode=head;
    
    
    if(position==0){
        newNode.next=head; 
        return newNode;
    }
    else{
        
        while(true){
            
            if(positionCounter+1>=position){
                break;
            }
                
            currentNode=currentNode.next;
            positionCounter++;
        }
        
        
        if(currentNode.next!=null){
            newNode.next=currentNode.next;
        }
        
        currentNode.next=newNode;
        
        return head;
    }
    
    
}
