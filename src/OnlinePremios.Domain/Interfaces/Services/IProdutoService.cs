using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface IProdutoService : IDisposable
    {
        Task Adicionar(Produto produto);
        Task Atualizar(Produto produto);
        Task Remover(Guid id);
    }
}
