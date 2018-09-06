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

        public EquationProperties getMyValue()
        {
            return this.equation;
        }
        public void setMyValue(EquationProperties equation)
        {
            this.equation = equation;
        }

        public void setNext(EquationNode aNode)
        {
            this.next = aNode;
        }

        public EquationNode getNext()
        {
            return this.next;
        }

        public void setPrevious(EquationNode aNode)
        {
            this.previous = aNode;
        }

        public EquationNode getPrevious()
        {
            return this.previous;
        }

        public string NodeToString()
        {
            return equation.FirstNumber.ToString() + equation.Symbol + equation.SecondNumber + "=" + equation.Result;
        }
    }
}
