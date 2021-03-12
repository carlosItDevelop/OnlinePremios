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

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasComSuasCotas()
        {
            return await _ctx.Compra.AsNoTracking().Include(f => f.Cotas).ToListAsync();
        }

        public async Task<IEnumerable<Compra>> ObterTodasAsComprasDeUmCliente(Guid clienteId)
        {
            return await _ctx.Compra.AsNoTracking().Where(x => x.ClienteId == clienteId).ToListAsync();
        }

        public Task<Compra> ObterUmaCompra(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
