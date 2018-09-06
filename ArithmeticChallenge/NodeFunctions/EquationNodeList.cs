using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class EquationNodeList
    {
        public EquationNode HeadNode;
        public EquationNode CurrentNode;
        public EquationNode TailNode;

        public static int count = 0;

        public EquationNodeList(){}

        public EquationNodeList(EquationNode node)
        {
            HeadNode = node;
            CurrentNode = node;
            TailNode = node;
            count++;
        }

        public EquationNode getCurrentNode() { return CurrentNode; }
        public EquationNode getHeadNode() { return HeadNode; }
        public EquationNode getTailNode() { return TailNode; }
        public void setCurrentNode(EquationNode node) { CurrentNode = node; }
        public void setHeadNode(EquationNode node) { HeadNode = node; }
        public void setTailNode(EquationNode node) { TailNode = node; }

        public void AddEquationNode(EquationNode node)
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
                HeadNode.setPrevious(node);
                CurrentNode.setNext(HeadNode);
                setHeadNode(CurrentNode);
                count++;
            }
        }
    }
}
