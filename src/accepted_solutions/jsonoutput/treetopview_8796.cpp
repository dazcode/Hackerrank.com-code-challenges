/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-top-view
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/*
struct node
{
    int data;
    node* left;
    node* right;
};

*/

bool firstOutput=false;

void top_view(node * root,bool topNode=true,bool searchLeft=true)
{
    if(searchLeft){
        if(root->left!=NULL){
            top_view(root->left,false,true);
            firstOutput=true;
        }
        if(firstOutput){
            cout << " ";
        }
        cout << root->data;
    }
    
    if(topNode){
        searchLeft=false;   
    }
    
    if(!searchLeft)
    {
        if(!topNode){
            cout << " ";
            cout << root->data;
        }
        if(root->right!=NULL){
            top_view(root->right,false,false);
        }
    }
}
