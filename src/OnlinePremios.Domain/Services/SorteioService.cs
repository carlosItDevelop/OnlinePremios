using OnlinePremios.Domain.Entities;
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

        public Task Adicionar(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Sorteio sorteio)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
