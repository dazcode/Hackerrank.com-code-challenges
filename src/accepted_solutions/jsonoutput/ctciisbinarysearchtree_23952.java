/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/ctci-is-binary-search-tree
this code may need to run in the hackerrank online ide to work correctly
*****************************/
/* Hidden stub code will pass a root argument to the function below. Complete the function to solve the challenge. Hint: you may want to write one or more helper functions.  

The Node class is defined as follows:
    class Node {
        int data;
        Node left;
        Node right;
     }

    boolean checkBST(Node root) {
        
        int currentData=root.data;
        printvalue("root:"+currentData);
            
        if(root.left!=null){
            printvalue("root:"+currentData+",left:"+root.left.data);
            if(!(root.left.data<currentData)){
                 return false;
            }
            if (!checkBST(root.left)){
                return false;
            }
        }
        
        if(root.right!=null){
            printvalue("root:"+currentData+",left:"+root.right.data);
            if(!(root.right.data>currentData)){
                 return false;
            }
            if (!checkBST(root.right)){
                return false;
            }
        }
        
        return true;
    }

    static void printvalue(String theValue){
        //System.out.println(theValue);
    }
    
   */

boolean checkBST(Node root) {
        return checkBST(root, Integer.MIN_VALUE, Integer.MAX_VALUE);
    }
    boolean checkBST(Node node, int min, int max) {
        if (node == null) return true;
        return  min < node.data && node.data < max && 
            checkBST(node.left, min, node.data) && 
            checkBST(node.right, node.data, max);
    }
