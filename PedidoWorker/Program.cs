using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PedidoWorker.Services;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices((context, services) =>
    {
        services.AddHostedService<PedidoWorkerService>();
        services.AddSingleton<MongoService>(); // serviço para acessar MongoDB
    })
    .Build();

await host.RunAsync();
