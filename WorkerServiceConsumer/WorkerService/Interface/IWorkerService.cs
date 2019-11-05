using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace WorkerServiceConsumer.WorkerService.Interface
{
    public interface IWorkerService
    {
        Task SyncSecurityUpdatesAsync();
    }
}
