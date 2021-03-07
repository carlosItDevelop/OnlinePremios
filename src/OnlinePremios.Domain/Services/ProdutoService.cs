using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{
    public class ProdutoService : BaseService, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository,
                              INotificator notificator) : base(notificator)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Inserir(produto);
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            await _produtoRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _produtoRepository?.Dispose();
        }
    }
}
