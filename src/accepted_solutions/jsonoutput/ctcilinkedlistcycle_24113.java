/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-linked-list-cycle
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
Detect a cycle in a linked list. Note that the head pointer may be 'null' if the list is empty.

A Node is defined as: 
    class Node {
        int data;
        Node next;
    }
*/
// we can run nextnode for 100+ or 
// add 

boolean hasCycle(Node head) {
    int cycleCount=0;
    boolean isCycle=false;
    while((head=getNext(head))!=null){
        cycleCount++;
        if(cycleCount>100){
            isCycle=true;
            break;
        }
    }
    return isCycle;
}

Node getNext(Node current){
    if(current==null){
        return null;
    }
    
    return current.next;
}
