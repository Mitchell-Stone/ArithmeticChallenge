using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class EquationNode
    {
        EquationProperties equation;

        public EquationNode previous;
        public EquationNode next;

        public EquationNode(EquationProperties equation)
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

        public void SetNext(EquationNode aNode)
        {
            this.next = aNode;
        }

        public EquationNode getNext()
        {
            return this.next;
        }

        public void SetPrevious(EquationNode aNode)
        {
            this.previous = aNode;
        }

        public EquationNode GetPrevious()
        {
            return this.previous;
        }

        public string NodeToString()
        {
            return equation.FirstNumber.ToString() + equation.Symbol + equation.SecondNumber + "=" + equation.Result;
        }
    }
}
