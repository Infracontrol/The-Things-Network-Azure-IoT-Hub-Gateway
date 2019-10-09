using Newtonsoft.Json;
using System;

namespace TheThingsNetworkGateway
{
    public class Telemetry
    {
        public string payload { get; set; }
        public int fPort { get; set; }

        public string ToJson(string payload, int fPort)
        {
            this.payload = payload;
            this.fPort = fPort;
            return JsonConvert.SerializeObject(this);
        }
    }
}