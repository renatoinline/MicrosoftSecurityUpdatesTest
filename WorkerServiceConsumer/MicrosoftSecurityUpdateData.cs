using Domain.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerServiceConsumer
{
    public class MicrosoftSecurityUpdateData
    {
        [JsonProperty("odata.context")]
        public string Context { get; set; }
        public List<SecurityUpdate> Value { get; set; }
    }
}
