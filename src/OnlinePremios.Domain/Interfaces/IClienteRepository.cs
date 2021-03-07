using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces
{
    public interface IClienteRepository : IGenericRepository<Cliente, Guid>
    {
        Task<Galeria> ObterUmClienteComSuasCotas(Guid id);
        Task<Galeria> ObterUmClienteComSorteioECotas(Guid id);
    }

}
