using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICompraItemRepository : IGenericRepository<CompraItem, Guid>
    {
        Task<IEnumerable<CompraItem>> ObterTodasOsCompraItemsDeUmaCompra(Guid compraId);
        Task<IEnumerable<CompraItem>> ObterTodasOsCompraItemsComSuasCompras();
        Task<CompraItem> ObterUmCompraItemComSuaCompra(Guid id);
    }
}
