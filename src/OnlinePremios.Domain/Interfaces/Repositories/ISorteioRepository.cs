using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{

    public interface ISorteioRepository : IGenericRepository<Sorteio, Guid>
    {
        // Todo: Busca / Filtro por Status

        Task<IEnumerable<Sorteio>> ObterTodasOsSorteiosDeUmCliente(Guid clienteId);
        Task<IEnumerable<Sorteio>> ObterTodasOsSorteiosPorDataDeSorteio();
        Task<Sorteio> ObterUmSorteio(Guid id);
    }

}
