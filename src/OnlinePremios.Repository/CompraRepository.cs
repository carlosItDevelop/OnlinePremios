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
    public class CompraRepository : RepositoryGeneric<Compra, Guid>, ICompraRepository
    {

        private readonly OnlinePremiosContext _ctx;

        public CompraRepository(OnlinePremiosContext context) : base(context)
        {
            this._ctx = context;
        }

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasComSeusItens()
        {
            return await _ctx.Compra.AsNoTracking().Include(f => f.CompraItens).ToListAsync();
        }

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasDeUmCliente(Guid clienteId)
        {
            return await _ctx.Compra.AsNoTracking().Where(x => x.ClienteId == clienteId).ToListAsync();
        }

        public async Task<Compra> ObterUmaCompra(Guid id)
        {
            return await _ctx.Compra.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
