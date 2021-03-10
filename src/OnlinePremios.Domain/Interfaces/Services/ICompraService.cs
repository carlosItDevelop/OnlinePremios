using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ICompraService : IDisposable
    {
        Task Adicionar(Compra compra);
        Task Atualizar(Compra compra);
        Task Remover(Guid id);
    }
}
