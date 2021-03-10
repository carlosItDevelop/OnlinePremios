using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICompraRepository : IGenericRepository<Compra, Guid>
    {
        Task<IEnumerable<Produto>> ObterTodasAsComprasDeUmCliente(Guid clienteId);
        Task<IEnumerable<Produto>> ObterTodasAsComprasComSeusClientes();
        Task<Produto> ObterUmaCompraComSeuCliente(Guid id);
    }
}

