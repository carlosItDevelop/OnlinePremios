using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IGenericRepository<Produto, Guid>
    {
        // Atributos e Classes expressivos (Clean Code)

        Task<IEnumerable<Produto>> ObterTodosOsProdutosDeUmaGaleria(Guid galeriaId);
        Task<IEnumerable<Produto>> ObterTodosOsProdutosComSuasGalerias();
        Task<Produto> ObterUmProdutoComSuaGaleria(Guid id);

    }
}
