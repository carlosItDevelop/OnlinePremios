using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlinePremios.Domain.Entities.bcCompra
{
    [Table("CarrinhoCompraItens")]
    public class CarrinhoCompraItem
    {
        public int CarrinhoCompraItemId { get; set; }
        public CompraItem CompraItem { get; set; }
        public int Quantidade { get; set; }

        [StringLength(100)]
        public string CarrinhoCompraId { get; set; }
    }
}
