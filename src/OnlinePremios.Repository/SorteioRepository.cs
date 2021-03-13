using OnlinePremios.Data.Orm;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Repository.Base;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Repository
{
    public class SorteioRepository : RepositoryGeneric<Sorteio, Guid>, ISorteioRepository
    {
        private readonly OnlinePremiosContext _ctx;

        public SorteioRepository(OnlinePremiosContext context) : base(context)
        {
            _ctx = context;
        }

        public Task<IEnumerable<Sorteio>> ObterTodasOsSorteiosComSeusClientes()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Sorteio>> ObterTodasOsSorteiosDeUmCliente(Guid clienteId)
        {
            throw new NotImplementedException();
        }

        public Task<Sorteio> ObterUmSorteio(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
