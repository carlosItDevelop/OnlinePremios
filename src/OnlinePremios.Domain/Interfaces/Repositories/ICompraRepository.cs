using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICompraRepository : IGenericRepository<Compra, Guid>
    {
        Task<IEnumerable<Compra>> ObterTodasAsComprasDeUmCliente(Guid clienteId);
        Task<IEnumerable<Compra>> ObterTodasAsComprasComSeusClientes();
        Task<Compra> ObterUmaCompraComSeuCliente(Guid id);
    }
}

