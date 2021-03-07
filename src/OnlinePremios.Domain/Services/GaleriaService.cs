using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{


    public class GaleriaService : BaseService, IGaleriaService
    {
        private readonly IGaleriaRepository _galeriaRepository;
        private readonly IProdutoRepository _produtoRepository;

        public GaleriaService(IGaleriaRepository galeriaRepository,
                                 IProdutoRepository produtoRepository,
                                 INotificator notificator) : base(notificator)
        {
            _galeriaRepository = galeriaRepository;
            _produtoRepository = produtoRepository;
        }

        public async Task Adicionar(Galeria galeria)
        {
            if (!ExecutarValidacao(new GaleriaValidation(), galeria)) return;

            await _galeriaRepository.Inserir(galeria);
        }

        public async Task Atualizar(Galeria galeria)
        {
            if (!ExecutarValidacao(new GaleriaValidation(), galeria)) return;

            if (_galeriaRepository.SelecionarTodos(f => f.Id != galeria.Id).Result.Any())
            {
                Notificar("Já existe uma Galeria para este sorteio infomado.");
                return;
            }

            await _galeriaRepository.Atualizar(galeria);
        }

        public async Task AtualizarProduto(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;

            await _produtoRepository.Atualizar(produto);
        }

        public async Task Remover(Guid id)
        {
            if (_galeriaRepository.ObterUmaGaleriaComSeusProtutos(id).Result.Produtos.Any())
            {
                Notificar("A Galeria possui produto(s) cadastrados!");
                return;
            }

            // Todo: Este id é da Galeria. Preciso de um id do produto!
            var produto = await _produtoRepository.SelecionarPorId(id); // Todo: Mudar aqui!

            if (produto != null)
            {
                await _produtoRepository.ExcluirPorId(produto.Id);
            }

            await _galeriaRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _galeriaRepository?.Dispose();
            _produtoRepository?.Dispose();
        }
    }

}
