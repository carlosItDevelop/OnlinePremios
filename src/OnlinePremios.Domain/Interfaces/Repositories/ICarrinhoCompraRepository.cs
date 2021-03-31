using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Entities.bcCompra;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePremios.Domain.Interfaces.Repositories
{
    public interface ICarrinhoCompraRepository : IGenericRepository<CompraItem, Guid>
    {


        public void AdicionarAoCarrinho(CompraItem compraItem);

        public int RemoverDoCarrinho(CompraItem compraItem);

        public List<CarrinhoCompraItem> GetCarrinhoCompraItens();

        public void LimparCarrinho();

        public decimal GetCarrinhoCompraTotal();

    }
}
