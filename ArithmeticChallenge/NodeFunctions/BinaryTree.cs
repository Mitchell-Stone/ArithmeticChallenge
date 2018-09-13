using System.Collections.Generic;
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

        public BinaryTree(EquationProperties value)
        {
            top = new BinaryTreeNode(value);
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

        public void PrintTree(BinaryTreeNode node, ref string printString)
        {
            if (node == null)
            {
                node = top;
                printString += PrintNode(node);
            }

            if (node.left != null)
            {
                PrintTree(node.left, ref printString);
                printString += PrintNode(node.left);
            }
            else
            {
                printString += PrintNode(node);
            }
            if (node.right != null)
            {
                PrintTree(node.right, ref printString);
            }
        }

        private static string PrintNode(BinaryTreeNode node)
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
