using Domain.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using WorkerServiceConsumer.Configuration;
using WorkerServiceConsumer.WorkerService.Interface;

namespace WorkerServiceConsumer.WorkerService
{
    public class WorkerService : IWorkerService
    {
        private readonly ISecurityUpdateService securityUpdateService;
        private readonly ApiConfiguration apiConfiguration;
        public WorkerService(ISecurityUpdateService securityUpdateService, ApiConfiguration apiConfiguration)
        {
            this.securityUpdateService = securityUpdateService;
            this.apiConfiguration = apiConfiguration;
        }

        public async Task SyncSecurityUpdatesAsync()
        {
            var data = await RequestDataAsync();

            foreach (var securityUpdate in data.Value)
            {
                var currentSecurityUpdate = securityUpdateService.FindById(securityUpdate.Id);
                if (currentSecurityUpdate == null)
                {
                    securityUpdateService.Insert(securityUpdate);
                }
            }
        }

        private async Task<MicrosoftSecurityUpdateData> RequestDataAsync()
        {
            MicrosoftSecurityUpdateData data = null;

            string url = apiConfiguration.Url;
            string apiKey = apiConfiguration.ApiKey;
            using (HttpClient client = new HttpClient())
            {
                // Request headers
                client.DefaultRequestHeaders.Add("api-key", apiKey);
                using (HttpResponseMessage res = await client.GetAsync(url))
                using (HttpContent content = res.Content)
                {
                    string json = await content.ReadAsStringAsync();
                    if (json != null)
                    {
                        data = JsonConvert.DeserializeObject<MicrosoftSecurityUpdateData>(json);
                    }
                }
            }

            return data;
        }
    }
}
