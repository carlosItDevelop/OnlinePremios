using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{


    public class GaleriaRepository : RepositoryGeneric<Galeria, Guid>, IGaleriaRepository
    {
        private readonly OnlinePremiosContext _ctx;

        public GaleriaRepository(OnlinePremiosContext context) : base(context)
        {
            _ctx = context;
        }

        public async Task<Galeria> ObterUmaGaleriaComSeusProtutos(Guid id)
        {
            return await _ctx.Galeria.AsNoTracking()
                .Include(c => c.Produtos)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Galeria> ObterUmaGaleriaComSorteioEProdutos(Guid id)
        {
            return await _ctx.Galeria.AsNoTracking()
                .Include(c => c.Produtos)
                .Include(c => c.Sorteio)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }

}
