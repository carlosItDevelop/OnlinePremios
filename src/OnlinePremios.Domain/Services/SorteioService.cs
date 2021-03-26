using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{

    public class SorteioService : BaseService, ISorteioService
    {
        private readonly ISorteioRepository _sorteioRepository;

        public SorteioService(ISorteioRepository sorteioRepository,
                                 INotificator notificator) : base(notificator)
        {
            _sorteioRepository = sorteioRepository;
        }

        public async Task Adicionar(Sorteio sorteio)
        {
            if (!ExecutarValidacao(new SorteioValidation(), sorteio)) return;

            await _sorteioRepository.Inserir(sorteio);
        }

        public async Task Atualizar(Sorteio sorteio)
        {
            if (!ExecutarValidacao(new SorteioValidation(), sorteio)) return;

            await _sorteioRepository.Atualizar(sorteio);
        }


        public async Task Remover(Guid id)
        {
            var sorteio = await _sorteioRepository.SelecionarPorId(id);

            if (sorteio == null)
            {
                Notificar("Sorteio não encontrado!");
                return;
            }

            await _sorteioRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _sorteioRepository?.Dispose();
        }

        public void GerarCotas(int numero, int quantidade)
        {
            var sorteio = new Sorteio();
            sorteio.GerarCota(numero, quantidade);
        }
    }
}

