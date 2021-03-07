using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface IClienteService : IDisposable
    {
        Task Adicionar(Cliente cliente);
        Task Atualizar(Cliente cliente);
        Task Remover(Guid id);
        //Task AddCompra(Compra compra);  // Todo: Implementar

    }
}
