using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ICotaItemService : IDisposable
    {
        Task Adicionar(CotaItem compraItem);
        Task Atualizar(CotaItem compraItem);
        Task Remover(Guid id);
    }
}
