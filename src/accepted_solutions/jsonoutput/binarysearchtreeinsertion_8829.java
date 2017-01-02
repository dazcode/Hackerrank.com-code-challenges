/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/binary-search-tree-insertion
this code may need to run in the hackerrank online ide to work correctly
*****************************/
 /* Node is defined as :
 class Node 
    int data;
    Node left;
    Node right;
    
    */

static Node Insert(Node root,int value)
{
    
    //compare current node value with parent right and left
    
    Node newNode=new Node();
    newNode.data=value;
    
    if(root!=null){
        searchTree(root,value,newNode);
        return root;
    }
    else{
        return newNode;
    }
    
}

static void searchTree(Node currentNode,int value,Node newNode){
    if(currentNode==null){
        return;
    }
    
    if(value<=currentNode.data){
        if(currentNode.left!=null){
            searchTree(currentNode.left,value,newNode);
        }
        else{
            
            currentNode.left=newNode;
        }
    }
    else{
        if(currentNode.right!=null){
            searchTree(currentNode.right,value,newNode);
        }
        else{
            
            currentNode.right=newNode;
        }
    }
    
}



