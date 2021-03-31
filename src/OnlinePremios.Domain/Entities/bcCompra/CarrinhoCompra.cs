using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities.bcCompra
{
    public class CarrinhoCompra
    {

        //injeta o contexto no construtor
        public CarrinhoCompra()
        {
        }

        //define as propriedades do Carrinho : Id e os Itens
        public string CarrinhoCompraId { get; set; }
        public List<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }


    }
}
