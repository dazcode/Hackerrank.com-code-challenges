/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/binary-search-tree-lowest-common-ancestor
this code may need to run in the hackerrank online ide to work correctly
*****************************/


 /* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

static Node lca(Node root,int v1,int v2)
    {

        return searchTree(root,v1,v2);
    
    }


static Node searchTree(Node currentNode,int v1,int v2){
    
    
        if(currentNode.data > v1 && currentNode.data > v2){
            return searchTree(currentNode.left, v1, v2);
        }else if(currentNode.data < v1 && currentNode.data < v2){
            return searchTree(currentNode.right, v1, v2);
        }
        
    
        
        return currentNode;   
    
}




