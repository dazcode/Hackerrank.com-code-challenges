/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/print-the-elements-of-a-linked-list
this code may need to run in the hackerrank online ide to work correctly
*****************************/
void Print(Node* head) {

	if (head != NULL) {
		cout << head->data << endl;
		if (head->next != NULL) {
			Print(head->next);
		}
	}
	else {
		//cout << "NULL";
	}
}