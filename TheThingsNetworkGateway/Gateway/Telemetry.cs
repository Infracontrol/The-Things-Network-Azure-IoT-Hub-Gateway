using Newtonsoft.Json;
using System;

namespace TheThingsNetworkGateway
{
    public class Telemetry
    {
        public string Payload { get; set; }
        //public string Schema { get; set; } = "1";
        public string ToJson(string data)
        {
            this.Payload = data;
            return JsonConvert.SerializeObject(this);
        }
    }
}