using System.Text;

namespace ArithmeticChallenge.NodeFunctions
{
    class BinaryTree
    {
        public BinaryTreeNode top;

        public BinaryTree()
        {
            top = null;
        }

        public void Add(EquationProperties myValue)
        {
            if (top == null)
            {
                //the tree is empty
                top = new BinaryTreeNode(myValue);
                return;
            }

            BinaryTreeNode currentNode = top;
            bool insert = false;

            do
            {
                if (myValue.Result < currentNode.treeEquation.Result)
                {
                    //insert to the left
                    if (currentNode.left == null)
                    {
                        currentNode.left = new BinaryTreeNode(myValue);
                        insert = true;
                    }
                    else
                    {
                        //move left
                        currentNode = currentNode.left;
                    }
                }

                if (myValue.Result >= currentNode.treeEquation.Result)
                {
                    // move right
                    if (currentNode.right == null)
                    {
                        currentNode.right = new BinaryTreeNode(myValue);
                        insert = true;
                    }
                    else
                    {
                        currentNode = currentNode.right;
                    }
                }
            } while (!insert);
        }//end function

        int counter = 0;

        public void PrintTreeSequential(BinaryTreeNode node, ref string myString)
        {
           
            if (counter == 0)
            {
                node = top;
                myString += PrintNode(node);
                counter = 1;
            }

            if (node.left != null)
            {
                myString += PrintNode(node.left);
                PrintTreeSequential(node.left, ref myString);              
            }
            else if (node.right != null)
            {
                myString += PrintNode(node.right);
                PrintTreeSequential(node.right, ref myString);             
            }
        }

        private string PrintNode(BinaryTreeNode node)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(node.treeEquation.Result.ToString());
            sb.Append("(");
            sb.Append(node.treeEquation.FirstNumber.ToString());
            sb.Append(node.treeEquation.Symbol);
            sb.Append(node.treeEquation.SecondNumber.ToString());
            sb.Append(")");

            return sb.ToString();
        }
    }
}
