/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-height-of-a-binary-tree
this code may need to run in the hackerrank online ide to work correctly
*****************************/

/*The tree node has data, left child and right child 
struct node
{
    int data;
    node* left;
    node* right;
};

*/
int height(node * root,bool isFirst=true)
{
    int theHeight=0;
    int leftHeight=0;
    int rightHeight=0;
    
    if(root->left!=NULL){
        leftHeight+=height(root->left,false);
        leftHeight++;
    }
    if(root->right!=NULL){
        rightHeight+=height(root->right,false);
        rightHeight++;
    }
    
     if(leftHeight>rightHeight){
        theHeight=leftHeight;
     }
     else{
        theHeight=rightHeight;
     }
    
    
   
   
    
    return theHeight;
}
  
