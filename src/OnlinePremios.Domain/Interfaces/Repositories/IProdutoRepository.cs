using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using System;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IGenericRepository<Produto, Guid>
    {
        
        //Task<IEnumerable<Produto>> ObterTodosOsProdutosDeUmaGaleria(Guid galeriaId);
        //Task<IEnumerable<Produto>> ObterTodosOsProdutosComSuasGalerias();
        //Task<Produto> ObterUmProdutoComSuaGaleria(Guid id);

    }
}
