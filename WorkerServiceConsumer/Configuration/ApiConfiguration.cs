using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerServiceConsumer.Configuration
{
    public class ApiConfiguration
    {
        //public ApiConfiguration(string url, string apiKey)
        //{
        //    this.Url = url;
        //    this.ApiKey = apiKey;
        //}

        public string Url { get; set; }
        public string ApiKey { get; set; }
    }
}
