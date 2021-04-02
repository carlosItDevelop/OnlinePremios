using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{
    public class CotaItemRepository : RepositoryGeneric<CotaItem, Guid>, ICotaItemRepository
    {

        private readonly OnlinePremiosContext _ctx;

        public CotaItemRepository(OnlinePremiosContext context) : base(context)
        {
            this._ctx = context;
        }

        public async Task<IEnumerable<CotaItem>> ObterTodasOsCompraItemsComSuasCompras()
        {
            // Todo Implementar ObterTodasOsCompraItemsComSuasCompras
            return null;
        }

        public async Task<IEnumerable<CotaItem>> ObterTodasOsCompraItemsDeUmaCompra(Guid compraId)
        {
            // Todo Implementar ObterTodasOsCompraItemsDeUmaCompra
            return null;
        }

        public async Task<CotaItem> ObterUmCompraItemComSuaCompra(Guid id)
        {
            // Todo Implementar ObterUmCompraItemComSuaCompra
            return null;
        }
    }
}
