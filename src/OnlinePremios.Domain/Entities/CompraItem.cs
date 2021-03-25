using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class CompraItem : EntityBase
    {
        public CompraItem(int numero, decimal valor)
        {
            this.Numero = numero;
            this.Valor = valor;
        }

        // to EF
        public CompraItem() { }

        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public Guid CompraId { get; set; }

        public virtual Compra Compra { get; set; }

    }
}

       