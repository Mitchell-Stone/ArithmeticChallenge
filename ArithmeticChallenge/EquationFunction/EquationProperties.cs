﻿using Newtonsoft.Json;
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

        public EquationProperties(byte[] data)
        {
            FirstNumber = BitConverter.ToUInt16(data, 0);
            SecondNumber = BitConverter.ToUInt16(data, 1);
            Result = BitConverter.ToUInt16(data, 2);
            int symbolLength = BitConverter.ToInt32(data, 3);
            Symbol = Encoding.ASCII.GetString(data, 4, symbolLength);
            IsCorrect = BitConverter.ToBoolean(data, 5);
        }

        public byte[] ToByteArray()
        {
            List<byte> byteList = new List<byte>();
            byteList.AddRange(BitConverter.GetBytes(FirstNumber));
            byteList.AddRange(BitConverter.GetBytes(SecondNumber));
            byteList.AddRange(BitConverter.GetBytes(Result));
            byteList.AddRange(BitConverter.GetBytes(Symbol.Length));
            byteList.AddRange(BitConverter.GetBytes(IsCorrect));
            return byteList.ToArray();
        }
    }
}
