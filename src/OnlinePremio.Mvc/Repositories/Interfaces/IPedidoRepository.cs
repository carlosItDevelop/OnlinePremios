using OnlinePremios.Mvc.Models;
using System.Collections.Generic;

namespace OnlinePremios.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
        Pedido GetPedidoById(int pedidoId);
        List<Pedido> GetPedidos();
    }
}
