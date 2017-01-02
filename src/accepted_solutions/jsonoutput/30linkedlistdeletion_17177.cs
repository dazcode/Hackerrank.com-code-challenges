/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-linked-list-deletion
this code may need to run in the hackerrank online ide to work correctly
*****************************/
  public static Node removeDuplicates(Node head){
      
      
      
      if(head!=null){
          if(head.next!=null){
              if(head.data==head.next.data){
                  head.next=head.next.next;
                  removeDuplicates(head);
              }
              else{
                  removeDuplicates(head.next);
              }
          }
      }
      
      return head;
  }