using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    class BinaryTreeNode
    {
        public EquationProperties treeEquation;
        public BinaryTreeNode top;
        public BinaryTreeNode left;
        public BinaryTreeNode right;
        public BinaryTreeNode previous;

        public BinaryTreeNode(EquationProperties equation)
        {
            treeEquation = equation;
            top = null;
            left = null;
            right = null;
            previous = null;
        }

        public string NodeToString()
        {
            return treeEquation.Result.ToString() + "(" +treeEquation.FirstNumber.ToString() + treeEquation.Symbol + treeEquation.SecondNumber.ToString() + "), ";
        }

    }
}
