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
    }
}
