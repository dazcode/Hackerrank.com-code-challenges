/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-postorder-traversal
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using namespace std;
void outputAnswer(node *root);
bool firstCall = true;

void postOrder(node *root,bool firstNode=true) {

	if (root->left != NULL) {
		postOrder(root->left,false);
	}
	if (root->right != NULL) {
		postOrder(root->right,false);
	}
    
    outputAnswer(root);
    

}

void outputAnswer(node *root){
    
    if(!firstCall){
        cout << " ";
    }
    firstCall=false;
    cout << root->data;
}