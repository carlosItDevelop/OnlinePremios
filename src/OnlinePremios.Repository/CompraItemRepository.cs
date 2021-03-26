using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{
    public class CompraItemRepository : RepositoryGeneric<CompraItem, Guid>, ICompraItemRepository
    {

        private readonly OnlinePremiosContext _ctx;

        public CompraItemRepository(OnlinePremiosContext context) : base(context)
        {
            this._ctx = context;
        }

        public async Task<IEnumerable<CompraItem>> ObterTodasOsCompraItemsComSuasCompras()
        {
            // Todo Implementar ObterTodasOsCompraItemsComSuasCompras
            return null;
        }

        public async Task<IEnumerable<CompraItem>> ObterTodasOsCompraItemsDeUmaCompra(Guid compraId)
        {
            // Todo Implementar ObterTodasOsCompraItemsDeUmaCompra
            return null;
        }

        public async Task<CompraItem> ObterUmCompraItemComSuaCompra(Guid id)
        {
            // Todo Implementar ObterUmCompraItemComSuaCompra
            return null;
        }
    }
}
