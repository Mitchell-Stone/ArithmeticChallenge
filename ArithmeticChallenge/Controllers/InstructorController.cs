using ArithmeticChallenge.NodeFunctions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge.Controllers
{
    class InstructorController
    {
        //returns the result of the calculation performed      
        public static int PerformCalculation(string first, string second, string symbol)
        {
            int firstNum = 0;
            int secondNum = 0;

            if (string.IsNullOrWhiteSpace(first))
            {
                firstNum = 0;
            }
            else
            {
                firstNum = Convert.ToInt32(first);                
            }

            if (string.IsNullOrWhiteSpace(second))
            {
                secondNum = 0;
            }
            else
            {
                secondNum = Convert.ToInt32(second);
            }

            int result = 0;
            switch (symbol)
            {
                case "+":
                    result = firstNum + secondNum;
                    break;
                case "-":
                    result = firstNum - secondNum;
                    break;
                case "x":
                    result = firstNum * secondNum;
                    break;
                case "/":
                    if (secondNum == 0)
                    {
                        result = 0;
                        break;
                    }
                    else
                    {
                        result = firstNum / secondNum;
                        break;
                    }
                default:
                    break;
            }
            return result;
        }

        public static string PrintLinkList(LinkListNodeList nodeList)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("HEAD");

            if (nodeList.HeadNode.GetNext() == null)
            {
                sb.Append("<-> " + nodeList.HeadNode.NodeToString());
            }
            else if (nodeList.HeadNode.GetNext() != null)
            {
                sb.Append("<-> " + nodeList.HeadNode.NodeToString());
                nodeList.CurrentNode = nodeList.HeadNode.GetNext();
                while (nodeList.CurrentNode != null)
                {
                    if (nodeList.CurrentNode.GetMyValue().IsCorrect == false)
                    {
                        sb.Append(" <-> " + nodeList.CurrentNode.NodeToString());
                        nodeList.CurrentNode = nodeList.CurrentNode.GetNext();
                    }
                }
            }

            sb.Append(" <-> TAIL");
            return sb.ToString();
        }
    }
}
