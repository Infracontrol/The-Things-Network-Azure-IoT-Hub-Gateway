using Newtonsoft.Json;
using System;

namespace TheThingsNetworkGateway
{
    public class Telemetry
    {
        public string payload { get; set; }
        public string ToJson(string data)
        {
            payload = data;
            return JsonConvert.SerializeObject(this);
        }
    }
}