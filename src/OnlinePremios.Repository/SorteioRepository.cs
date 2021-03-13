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
    public class SorteioRepository : RepositoryGeneric<Sorteio, Guid>, ISorteioRepository
    {
        // Todo: Implementar buscas por status, em todos os services

        private readonly OnlinePremiosContext _ctx;

        public SorteioRepository(OnlinePremiosContext context) : base(context)
        {
            _ctx = context;
        }

        public async Task<IEnumerable<Sorteio>> ObterTodasOsSorteiosPorDataDeSorteio()
        {
            return await _ctx.Sorteio.AsNoTracking().OrderBy(x => x.DataSorteio).ToListAsync();
        }


        public async Task<Sorteio> ObterUmSorteio(Guid id)
        {
            return await _ctx.Sorteio.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
