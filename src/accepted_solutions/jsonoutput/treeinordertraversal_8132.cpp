/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-inorder-traversal
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using namespace std;
void outputAnswer(node *root);
bool firstCall = true;

void inOrder(node *root,bool firstNode=true) {

	if (root->left != NULL) {
		inOrder(root->left,false);
	}
    outputAnswer(root);
    
	if (root->right != NULL) {
		inOrder(root->right,false);
	}
    
    
    

}

void outputAnswer(node *root){
    
    if(!firstCall){
        cout << " ";
    }
    firstCall=false;
    cout << root->data;
}