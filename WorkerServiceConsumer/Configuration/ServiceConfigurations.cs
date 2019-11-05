using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerServiceConsumer.Configuration
{
    public class ServiceConfigurations : IWorkerConfiguration
    {        
        public int Intervalo { get; set; }
    }
}
