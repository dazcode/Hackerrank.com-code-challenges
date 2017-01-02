/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/tree-level-order-traversal
this code may need to run in the hackerrank online ide to work correctly
*****************************/
   /* 
    
    class Node 
       int data;
       Node left;
       Node right;
   */



   void LevelOrder(Node root)
    {
        LinkedList<Node> treeNodes=new LinkedList<Node>();
        ArrayList<Integer> treeArray=new ArrayList<Integer>();
        treeNodes.add(root);
       
        processQueue(treeNodes,treeArray);
       
        for(int i=0;i<treeArray.size();i++){
            System.out.print(treeArray.get(i));
            if(i+1<treeArray.size()){
                System.out.print(" ");   
            }
        }
        
        
    }
        
        
    void processQueue(LinkedList<Node> treeNodes,ArrayList<Integer> treeArray){
        
        Node currentNode = treeNodes.poll();
        
        if(currentNode==null){
            return;
        }
        
        treeArray.add(currentNode.data);
        
        if(currentNode.left!=null){
            
            treeNodes.add(currentNode.left);
        }
        if(currentNode.right!=null){
            
            treeNodes.add(currentNode.right);
        }
        
        
        processQueue(treeNodes,treeArray);
        
        
    }
    




      
