using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticChallengeStudent
{
    [Serializable]
    class EquationProperties
    {
        [JsonProperty("first_number")]
        public ushort FirstNumber { get; set; }
        [JsonProperty("second_number")]
        public ushort SecondNumber { get; set; }
        [JsonProperty("symbol")]
        public string Symbol { get; set; }
        [JsonProperty("result")]
        public ushort Result { get; set; }
        [JsonProperty("is_correct")]
        public bool IsCorrect { get; set; }

        public EquationProperties() { }

        public EquationProperties(ushort firstNumber, ushort secondNumber, string symbol, ushort result, bool isCorrect)
        {
            FirstNumber = firstNumber;
            SecondNumber = secondNumber;
            Symbol = symbol;
            Result = result;
            IsCorrect = isCorrect;
        }
    }
}
