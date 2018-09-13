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
