using Microsoft.EntityFrameworkCore;
using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces;
using OnlinePremios.Repository.Base;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{


    public class ClienteRepository : RepositoryGeneric<Cliente, Guid>, IClienteRepository
    {
        private readonly OnlinePremiosContext _ctx;

        public ClienteRepository(OnlinePremiosContext context) : base(context)
        {
            this._ctx = context;
        }


        public async Task<Cliente> ObterUmClienteComSuasCompras(Guid id)
        {
            return await this._ctx.Cliente.AsNoTracking()
                .Include(x=>x.Compras)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

    }

}
