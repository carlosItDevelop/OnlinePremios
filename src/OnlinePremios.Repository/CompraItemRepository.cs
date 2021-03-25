using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public virtual async Task<IEnumerable<CompraItem>> ObterTodasAsCompraItemsComSuasCompras()
        {
            return await _ctx.CompraItem.AsNoTracking().Include(f => f.Compra)
                .OrderBy(p => p.DataCadastro).ToListAsync();
        }

        public virtual async Task<IEnumerable<CompraItem>> ObterTodasAsCompraItemsDeUmaCompra(Guid compraId)
        {
            return await SelecionarTodos(p => p.Id == compraId);
        }


        public virtual async Task<CompraItem> ObterUmaCompraItemComSuaCompra(Guid id)
        {
            return await _ctx.CompraItem.AsNoTracking().Include(f => f.Compra)
                .FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}
