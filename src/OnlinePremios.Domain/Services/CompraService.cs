using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.Validations;
using OnlinePremios.Domain.Interfaces.Notify;
using OnlinePremios.Domain.Interfaces.Repositories;
using OnlinePremios.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlinePremios.Domain.Services
{
    public class CompraService : BaseService, ICompraService
    {
        private readonly ICompraRepository _compraRepository;
        private readonly ICotaRepository _cotaRepository;
        private readonly IClienteRepository _clienteRepository;


        public CompraService(ICompraRepository compraRepository, 
                             ICotaRepository cotaRepository,
                             IClienteRepository clienteRepository,
                             INotificator notificator) : base(notificator)
        {
            _compraRepository = compraRepository;
            _cotaRepository = cotaRepository;
            _clienteRepository = clienteRepository;
        }

        public async Task Adicionar(Compra compra)
        {
            if (!ExecutarValidacao(new CompraValidation(), compra)) return;

            await _compraRepository.Inserir(compra);

        }



        public async Task Atualizar(Compra compra)
        {
            if (!ExecutarValidacao(new CompraValidation(), compra)) return;

            if (_clienteRepository.SelecionarTodos(f => f.Id == compra.ClienteId).Result.Any())
            {
                Notificar("Já existe um Cliente para esta compra infomado.");
                return;
            }

            await _compraRepository.Atualizar(compra);
        }



        public Task Remover(Guid id)
        {
            if (_compraRepository.ObterUmaCompraComSeuCliente(id).Result. .Any())
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


        public Task AdicionarCotas(Cota cota)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _compraRepository?.Dispose();
            _cotaRepository?.Dispose();
            _clienteRepository?.Dispose();
        }


    }
}
