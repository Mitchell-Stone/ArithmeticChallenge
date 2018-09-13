using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.NodeFunctions
{
    partial class BinaryTreeNode
    {
        public EquationProperties treeEquation;
        public BinaryTreeNode left;
        public BinaryTreeNode right;

        public BinaryTreeNode(EquationProperties equation)
        {
            treeEquation = equation;
            left = null;
            right = null;
        }
    }
}
