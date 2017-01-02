/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-binary-trees
this code may need to run in the hackerrank online ide to work correctly
*****************************/
	




static void levelOrder(Node root){
      
        List<int> nodeList=new List<int>();
        Queue<Node> nodeQueue=new Queue<Node>();
        nodeQueue.Enqueue(root);
        
        while(nodeQueue.Count()>0)
        {
            root=nodeQueue.Dequeue();
            nodeList.Add(root.data);

            if(root.left!=null){
                nodeQueue.Enqueue(root.left);
            }
            if(root.right!=null){
                nodeQueue.Enqueue(root.right);
            }
        }
    
        Console.WriteLine(string.Join(" ",nodeList.ToArray()));
    
      
    }