using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces
{
    public interface IProdutoService : IDisposable
    {
        Task Add(Produto produto);
        Task Update(Produto produto);
        Task Remove(Guid id);
    }
}
