using Azure.Messaging.ServiceBus;
using System.Text.Json;
using PedidoAPI.Models;
using System.Threading.Tasks; // ajusta o namespace do teu Pedido se precisar

namespace PedidoAPI.Services
{
    public class PedidoProducerService
    {
        private readonly ServiceBusClient _serviceBusClient;
        private readonly ServiceBusSender _sender;

        public PedidoProducerService(ServiceBusClient serviceBusClient)
        {
            _serviceBusClient = serviceBusClient;
            _sender = _serviceBusClient.CreateSender("pedidos-queue"); // Nome da queue no Service Bus
        }

        public async Task EnviarPedidoAsync(Pedido pedido)
        {
            var mensagemJson = JsonSerializer.Serialize(pedido);
            var message = new ServiceBusMessage(mensagemJson);

            await _sender.SendMessageAsync(message);
        }
    }
}