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
    public class CotaRepository : RepositoryGeneric<Cota, Guid>, ICotaRepository
    {
        private readonly OnlinePremiosContext _ctx;
        public CotaRepository(OnlinePremiosContext context) : base(context) 
        {
            this._ctx = context;
        }

        public virtual async Task<IEnumerable<Cota>> ObterTodasAsCotasComSuasCompras()
        {
            return await _ctx.Cota.AsNoTracking().Include(f => f.Compra)
                .OrderBy(p => p.DataCadastro).ToListAsync();
        }

        public virtual async Task<IEnumerable<Cota>> ObterTodasAsCotasDeUmaCompra(Guid compraId)
        {
            return await SelecionarTodos(p => p.Id == compraId);
        }


        public virtual async Task<Cota> ObterUmaCotaComSuaCompra(Guid id)
        {
            return await _ctx.Cota.AsNoTracking().Include(f => f.Compra)
                .FirstOrDefaultAsync(p => p.Id == id);
        }


    }
}
