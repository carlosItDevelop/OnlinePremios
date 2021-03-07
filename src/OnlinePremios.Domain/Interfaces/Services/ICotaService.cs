using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface ICotaService : IDisposable
    {
        Task Adicionar(Cota cota);
        Task Atualizar(Cota cota);
        Task Remover(Guid id);
    }
}
