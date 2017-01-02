/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-linked-list
this code may need to run in the hackerrank online ide to work correctly
*****************************/
public static Node insert(Node head, int data)
        {
            Node newNode = new Node(data);
            newNode.data = data;

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node loopNode = head;
                while (loopNode.next != null)
                {
                    loopNode = loopNode.next;
                }
                loopNode.next = newNode;
            }
            

            return head;
        }