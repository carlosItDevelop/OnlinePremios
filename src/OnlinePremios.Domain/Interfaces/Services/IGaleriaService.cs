using OnlinePremios.Domain.Entities;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Interfaces.Services
{
    public interface IGaleriaService : IDisposable
    {
        Task Adicionar(Galeria galeria);
        Task Atualizar(Galeria galeria);
        Task Remover(Guid id);

        Task AtualizarProduto(Produto produto);  // Todo: Ou atualizo aqui (Raiz de agregação ou em ProdutoService. 
    }
}
