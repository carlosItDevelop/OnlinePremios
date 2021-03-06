using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces
{
    public interface IGaleriaRepository : IGenericRepository<Galeria, Guid>
    {
        Task<Galeria> ObterUmaGaleriaComSeusProtutos(Guid id);
        Task<Galeria> ObterUmaGaleriaComSorteioEProdutos(Guid id);
    }

}
