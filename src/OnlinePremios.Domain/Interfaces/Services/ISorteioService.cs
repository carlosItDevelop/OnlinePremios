using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ISorteioService : IDisposable
    {
        Task Adicionar(Sorteio sorteio);
        Task Atualizar(Sorteio sorteio);
        Task Remover(Guid id);
    }
}
