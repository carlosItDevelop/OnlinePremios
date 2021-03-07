using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICotaRepository : IGenericRepository<Cota, Guid>
    {

        Task<IEnumerable<Cota>> ObterTodasAsCotasDeUmaCompra(Guid compraId);
        Task<IEnumerable<Cota>> ObterTodasAsCotasComSuasCompras();
        Task<Cota> ObterUmaCotaComSuaCompra(Guid id);
    }

}
