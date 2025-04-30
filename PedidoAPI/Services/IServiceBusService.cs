using PedidoAPI.Models;
using System.Threading.Tasks;

namespace PedidoAPI.Services
{
    public interface IServiceBusService
    {
        Task EnviarMensagemAsync(Pedido pedido);
    }
}
