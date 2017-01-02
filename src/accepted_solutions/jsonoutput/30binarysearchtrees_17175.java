/*****************************
Code by: David Zentner dazcode@gmail.com
http://www.dazcode.com/
this code is an accepted solution for code challenge located at:
https://www.hackerrank.com/challenges/30-binary-search-trees
this code may need to run in the hackerrank online ide to work correctly
*****************************/
static int getHeight(Node root)
    {
            int height = 0;

            if (root!=null)
            {
                int leftHeight = 0;
                int rightHeight = 0;

                if (root.right != null)
                {
                    rightHeight=getHeight(root.right);
                    rightHeight++;
                }
                if (root.left != null)
                {
                    leftHeight=getHeight(root.left);
                    leftHeight++;
                }
                if (leftHeight > rightHeight)
                {
                    height = leftHeight;
                }
                else
                {
                    height = rightHeight;
                }
            }
            

            return height;
    }
