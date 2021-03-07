using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces;
using System;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{


    public class CotaService : BaseService, ICotaService
    {
        private readonly ICotaRepository _cotaRepository;

        public CotaService(ICotaRepository cotaRepository,
                              INotificator notificator) : base(notificator)
        {
            _cotaRepository = cotaRepository;
        }

        public async Task Adicionar(Cota cota)
        {
            if (!ExecutarValidacao(new CotaValidation(), cota)) return;

            await _cotaRepository.Inserir(cota);
        }

        public async Task Atualizar(Cota cota)
        {
            if (!ExecutarValidacao(new CotaValidation(), cota)) return;

            await _cotaRepository.Atualizar(cota);
        }

        public async Task Remover(Guid id)
        {
            await _cotaRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _cotaRepository?.Dispose();
        }
    }

}
