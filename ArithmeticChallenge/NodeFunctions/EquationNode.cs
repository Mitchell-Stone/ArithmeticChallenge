using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class BinaryTreeNode
    {
        public EquationProperties equation;

        public BinaryTreeNode previous;
        public BinaryTreeNode next;

        public EquationProperties GetMyValue()
        {
            return this.equation;
        }
        public void SetMyValue(EquationProperties equation)
        {
            this.equation = equation;
        }

        public void SetNext(BinaryTreeNode aNode)
        {
            this.next = aNode;
        }

        public BinaryTreeNode getNext()
        {
            return this.next;
        }

        public void SetPrevious(BinaryTreeNode aNode)
        {
            this.previous = aNode;
        }

        public BinaryTreeNode GetPrevious()
        {
            return this.previous;
        }

        public string NodeToString()
        {
            return equation.FirstNumber.ToString() + equation.Symbol + equation.SecondNumber + "=" + equation.Result;
        }
    }
}
