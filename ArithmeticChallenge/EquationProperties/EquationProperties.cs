using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallenge
{
    [Serializable]
    class EquationProperties
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }
        public string Symbol { get; set; }
        public int Result { get; set; }
        public bool IsCorrect { get; set; }
    }
}
