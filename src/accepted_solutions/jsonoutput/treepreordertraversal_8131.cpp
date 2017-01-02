/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-preorder-traversal
this code may need to run in the hackerrank online ide to work correctly
*****************************/
using namespace std;


void preOrder(node *root) {
	cout << root->data;
    
	if (root->left != NULL) {
        cout << " ";
		preOrder(root->left);
	}
	if (root->right != NULL) {
        cout << " ";
		preOrder(root->right);
	}

}