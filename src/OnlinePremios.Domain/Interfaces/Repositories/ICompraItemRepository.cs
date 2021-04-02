using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICompraItemRepository : IGenericRepository<CotaItem, Guid>
    {
        Task<IEnumerable<CotaItem>> ObterTodasOsCompraItemsDeUmaCompra(Guid compraId);
        Task<IEnumerable<CotaItem>> ObterTodasOsCompraItemsComSuasCompras();
        Task<CotaItem> ObterUmCompraItemComSuaCompra(Guid id);
    }
}
