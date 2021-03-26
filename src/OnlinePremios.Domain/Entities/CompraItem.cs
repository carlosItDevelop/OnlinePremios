using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class CompraItem : EntityBase
    {
        public CompraItem(int numero, decimal valor, Guid compraId)
        {
            this.Numero = numero;
            this.Valor = valor;
            this.CompraId = compraId;
        }

        // to EF
        public CompraItem() { }

        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public Guid CompraId { get; set; }

        public virtual Compra Compra { get; set; }

    }
}
