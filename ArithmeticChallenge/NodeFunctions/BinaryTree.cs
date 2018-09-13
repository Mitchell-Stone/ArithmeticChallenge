namespace ArithmeticChallenge.NodeFunctions
{
    class BinaryTree
    {
        public BinaryTreeNode top;

        public BinaryTree(EquationProperties myValue)
        {
            top = new BinaryTreeNode(myValue);
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
                if (myValue.Result < currentNode.GetMyValue().Result)
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

                    if (myValue.Result >= currentNode.GetMyValue().Result)
                    {
                        // move right
                        if (currentNode.right == null)
                        {
                            currentNode.right = new BinaryTreeNode(myValue);
                        }
                        else
                        {
                            currentNode = currentNode.right;
                        }
                    }
                }
            } while (!insert);
        }//end function

        public void PrintTreeSequential(BinaryTreeNode node, ref string myString)
        {
            if (node == null)
            {
                node = top;
            }

            if (node.left != null)
            {
                PrintTreeSequential(node.left, ref myString);
                myString += node.GetMyValue().Result.ToString() + 
                    "(" +
                    node.GetMyValue().FirstNumber.ToString() +
                    node.GetMyValue().Symbol +
                    node.GetMyValue().SecondNumber.ToString() + 
                    ")";
            }
            else
            {
                myString += node.GetMyValue().Result.ToString() +
                    "(" +
                    node.GetMyValue().FirstNumber.ToString() +
                    node.GetMyValue().Symbol +
                    node.GetMyValue().SecondNumber.ToString() +
                    ")";
            }

            if (node.right != null)
            {
                PrintTreeSequential(node.right, ref myString);
                myString += node.GetMyValue().Result.ToString() +
                    "(" +
                    node.GetMyValue().FirstNumber.ToString() +
                    node.GetMyValue().Symbol +
                    node.GetMyValue().SecondNumber.ToString() +
                    ")";
            }
            else
            {
                myString += node.GetMyValue().Result.ToString() +
                    "(" +
                    node.GetMyValue().FirstNumber.ToString() +
                    node.GetMyValue().Symbol +
                    node.GetMyValue().SecondNumber.ToString() +
                    ")";
            }

        }
    }
}
