using OnlinePremio.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremio.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
        Pedido GetPedidoById(int pedidoId);
        List<Pedido> GetPedidos();
    }
}
