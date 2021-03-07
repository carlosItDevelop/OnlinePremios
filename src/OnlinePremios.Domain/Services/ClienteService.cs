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

    public class ClienteService : BaseService, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository fornecedorRepository,
                                 INotificator notificator) : base(notificator)
        {
            _clienteRepository = fornecedorRepository;
        }

        public async Task Adicionar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return;

            if (_clienteRepository.SelecionarTodos(f => f.Documento == cliente.Documento).Result.Any())
            {
                Notificar("Já existe um cliente com este documento infomado.");
                return;
            }

            await _clienteRepository.Inserir(cliente);
        }

        public async Task Atualizar(Cliente cliente)
        {
            if (!ExecutarValidacao(new ClienteValidation(), cliente)) return;

            if (_clienteRepository.SelecionarTodos(f => f.Documento == cliente.Documento && f.Id != cliente.Id).Result.Any())
            {
                Notificar("Já existe um cliente com este documento infomado.");
                return;
            }

            await _clienteRepository.Atualizar(cliente);
        }


        public async Task Remover(Guid id)
        {
            if (_clienteRepository.SelecionarPorId(id).Result.Compras.Any())
            {
                Notificar("O cliente possui comprass cadastrados!");
                return;
            }

            await _clienteRepository.ExcluirPorId(id);
        }

        public void Dispose()
        {
            _clienteRepository?.Dispose();
        }


    }

}
