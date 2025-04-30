using System;

namespace PedidoAPI.Models
{
    public class Pedido
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime DataPedido { get; set; } = DateTime.Now;
        public string Cliente { get; set; }
        public string Pecas { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal => Quantidade * ValorUnitario;
    }
}