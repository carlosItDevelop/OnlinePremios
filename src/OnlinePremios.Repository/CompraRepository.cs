using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
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

        public Task<IEnumerable<Compra>> ObterTodasAsComprasDeUmCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Compra> ObterUmaCompraComSeuCliente(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
