using Data;
using IoC;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.IO;
using WorkerServiceConsumer.Configuration;
using WorkerServiceConsumer.WorkerService.Interface;

namespace WorkerServiceConsumer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddHostedService<Worker>();
                    RegisterServices(services);
                });

        private static void RegisterServices(IServiceCollection services)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json");

            var configuration = builder.Build();

            //services.AddDbContext<MicrosoftSecurityUpdateContext>();
            services.AddDbContext<MicrosoftSecurityUpdateContext>(options => 
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            //Add Service
            services.AddScoped<IWorkerService, WorkerService.WorkerService>();

            ApiConfiguration apiConfiguration;

            apiConfiguration = new ApiConfiguration();
            new ConfigureFromConfigurationOptions<ApiConfiguration>(
                configuration.GetSection("ApiConfiguration"))
                    .Configure(apiConfiguration);

            services.AddScoped<ApiConfiguration>(e => apiConfiguration);

            // Adding dependencies from another layers (isolated from Presentation)
            NativeInjectorBootStrapper.RegisterServices(services);
        }
    }
}
