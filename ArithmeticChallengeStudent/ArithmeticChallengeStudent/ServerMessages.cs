/*
 *      Student Number: 451381461
 *      Name:           Mitchell Stone
 *      Date:           14/09/2018
 *      Purpose:        A class the deserializes messages from the server that is not an equation
 *      Known Bugs:     nill
 */

using Newtonsoft.Json;
using System;

namespace ArithmeticChallengeStudent
{
    [Serializable]
    class ServerMessages
    {
        [JsonProperty("server_connection")]
        public string Message { get; set; }

        public ServerMessages(string message)
        {
            Message = message;
        }
    }
}
