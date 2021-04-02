using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{
    public class CotaItemService : BaseService, ICotaItemService
    {
        private readonly ICotaItemRepository _cotaItemRepository;

        public CotaItemService(ICotaItemRepository cotaItemRepository,
                              INotificator notificator) : base(notificator)
        {
            _cotaItemRepository = cotaItemRepository;
        }

        public Task Adicionar(CotaItem compraItem)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(CotaItem compraItem)
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
