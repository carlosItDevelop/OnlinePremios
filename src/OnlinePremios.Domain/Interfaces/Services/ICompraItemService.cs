using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ICompraItemService : IDisposable
    {
        Task Adicionar(CompraItem compraItem);
        Task Atualizar(CompraItem compraItem);
        Task Remover(Guid id);
    }
}
