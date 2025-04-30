using Microsoft.Extensions.Hosting;
using System.Threading;
using System.Threading.Tasks;

namespace PedidoWorker.Services
{
    public class PedidoWorkerService : BackgroundService
    {
        private readonly MongoService _mongoService;

        public PedidoWorkerService(MongoService mongoService)
        {
            _mongoService = mongoService;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // Aqui seria a escuta no Service Bus
                // Exemplo: await _mongoService.GravarPedido(pedido);
                await Task.Delay(1000, stoppingToken); // só simula processamento
            }
        }
    }
}
