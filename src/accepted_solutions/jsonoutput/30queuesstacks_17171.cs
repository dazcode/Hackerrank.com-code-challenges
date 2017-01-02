/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-queues-stacks
this code may need to run in the hackerrank online ide to work correctly
*****************************/
class Solution {
    //Write your code here
    Queue<char> theQ = new Queue<char>();
        Stack<char> theStack = new Stack<char>();

        void pushCharacter(char ch)
        {
            theStack.Push(ch);
        }
        void enqueueCharacter(char ch)
        {
            theQ.Enqueue(ch);
        }
        char popCharacter()
        {
            return theStack.Pop();
        }
        char dequeueCharacter()
        {
            return theQ.Dequeue();
        }