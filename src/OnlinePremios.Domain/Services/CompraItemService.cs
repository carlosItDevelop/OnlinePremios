using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{


    public class CompraItemService : BaseService, ICompraItemService
    {
        private readonly ICompraItemRepository _compraItemRepository;

        public CompraItemService(ICompraItemRepository compraItemRepository,
                              INotificator notificator) : base(notificator)
        {
            _compraItemRepository = compraItemRepository;
        }

        public async Task Adicionar(CompraItem compraItem)
        {
            if (!ExecutarValidacao(new CompraItemValidation(), compraItem)) return;

            await _compraItemRepository.Inserir(compraItem);
        }

        public async Task Atualizar(CompraItem compraItem)
        {
            if (!ExecutarValidacao(new CompraItemValidation(), compraItem)) return;

            await _compraItemRepository.Atualizar(compraItem);
        }

        public async Task Remover(Guid id)
        {
            await _compraItemRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _compraItemRepository?.Dispose();
        }
    }

}
