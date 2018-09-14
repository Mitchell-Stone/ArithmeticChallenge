/*
 *      Student Number: 451381461
 *      Name:           Mitchell Stone
 *      Date:           14/09/2018
 *      Purpose:        Seriliazable properties for equations receieved
 *      Known Bugs:     nill
 */

using Newtonsoft.Json;
using System;

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
