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
    public class CompraService : BaseService, ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        private readonly ICotaRepository _cotaRepository;

        public CompraService(ICompraRepository compraRepository, 
                             ICotaRepository cotaRepository,
                             INotificator notificator) : base(notificator)
        {
            _compraRepository = compraRepository;
            _cotaRepository = cotaRepository;
        }

        public Task Adicionar(Compra compra)
        {
            throw new NotImplementedException();
        }

        public Task AdicionarCotas(Cota cota)
        {
            throw new NotImplementedException();
        }

        public Task Atualizar(Compra compra)
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
