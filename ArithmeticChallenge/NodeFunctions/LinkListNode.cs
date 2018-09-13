using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class LinkListNode
    {
        public EquationProperties equation;

        public LinkListNode previous;
        public LinkListNode next;

        public LinkListNode(EquationProperties equation)
        {
            this.equation = equation;
        }

        public EquationProperties GetMyValue()
        {
            return this.equation;
        }
        public void SetMyValue(EquationProperties equation)
        {
            this.equation = equation;
        }

        public void SetNext(LinkListNode aNode)
        {
            this.next = aNode;
        }

        public LinkListNode GetNext()
        {
            return this.next;
        }

        public void SetPrevious(LinkListNode aNode)
        {
            this.previous = aNode;
        }

        public LinkListNode GetPrevious()
        {
            return this.previous;
        }

        public string NodeToString()
        {
            return equation.FirstNumber.ToString() + equation.Symbol + equation.SecondNumber.ToString() + "=" + equation.Result.ToString();
        }
    }
}
