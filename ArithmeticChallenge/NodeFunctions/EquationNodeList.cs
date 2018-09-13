using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class EquationNodeList
    {
        public BinaryTreeNode HeadNode;
        public BinaryTreeNode CurrentNode;
        public BinaryTreeNode TailNode;

        public static int count = 0;

        public EquationNodeList(){}

        public EquationNodeList(BinaryTreeNode node)
        {
            HeadNode = node;
            CurrentNode = node;
            TailNode = node;
            count++;
        }

        public BinaryTreeNode getCurrentNode() { return CurrentNode; }
        public BinaryTreeNode getHeadNode() { return HeadNode; }
        public BinaryTreeNode getTailNode() { return TailNode; }

        public void setCurrentNode(BinaryTreeNode node) { CurrentNode = node; }
        public void setHeadNode(BinaryTreeNode node) { HeadNode = node; }
        public void setTailNode(BinaryTreeNode node) { TailNode = node; }

        public void AddEquationNode(BinaryTreeNode node)
        {
            if ((HeadNode == null) && (CurrentNode == null) && (TailNode == null))
            {
                // this firstNode in the list
                HeadNode = node;
                CurrentNode = node;
                TailNode = node;
                count++;
            }
            else
            {
                CurrentNode = node;
                HeadNode.SetPrevious(node);
                CurrentNode.SetNext(HeadNode);
                setHeadNode(CurrentNode);
                count++;
            }
        }
    }
}
