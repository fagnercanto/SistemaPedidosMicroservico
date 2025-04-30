using Microsoft.AspNetCore.Mvc;
using PedidoAPI.Models;
using PedidoAPI.Services;
using System.Threading.Tasks;

namespace PedidoAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PedidoController : ControllerBase
    {
        private readonly IServiceBusService _serviceBusService;

        public PedidoController(IServiceBusService serviceBusService)
        {
            _serviceBusService = serviceBusService;
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Pedido pedido)
        {
            await _serviceBusService.EnviarMensagemAsync(pedido);
            return Accepted(pedido);
        }
    }
}