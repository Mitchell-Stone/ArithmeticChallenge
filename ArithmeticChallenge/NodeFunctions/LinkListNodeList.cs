using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class LinkListNodeList
    {
        public LinkListNode HeadNode;
        public LinkListNode CurrentNode;
        public LinkListNode TailNode;

        public static int count = 0;

        public LinkListNodeList(){}

        public LinkListNodeList(LinkListNode node)
        {
            HeadNode = node;
            CurrentNode = node;
            TailNode = node;
            count++;
        }

        public LinkListNode getCurrentNode() { return CurrentNode; }
        public LinkListNode getHeadNode() { return HeadNode; }
        public LinkListNode getTailNode() { return TailNode; }

        public void setCurrentNode(LinkListNode node) { CurrentNode = node; }
        public void setHeadNode(LinkListNode node) { HeadNode = node; }
        public void setTailNode(LinkListNode node) { TailNode = node; }

        public void AddEquationNode(LinkListNode node)
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
