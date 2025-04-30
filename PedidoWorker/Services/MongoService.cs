// MongoService.cs
using MongoDB.Driver;
using PedidoWorker.Models;
using System.Threading.Tasks;

namespace PedidoWorker.Services
{
    public class MongoService
    {
        private readonly IMongoCollection<Pedido> _pedidos;

        public MongoService()
        {
            var client = new MongoClient("mongodb://localhost:27017"); // ou connection string real
            var database = client.GetDatabase("Loja");
            _pedidos = database.GetCollection<Pedido>("Pedidos");
        }

        public async Task GravarPedido(Pedido pedido)
        {
            await _pedidos.InsertOneAsync(pedido);
        }
    }
}
