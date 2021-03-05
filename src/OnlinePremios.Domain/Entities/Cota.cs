using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(int numero, Guid compraId, decimal valor)
        {
            this.Numero = numero;
            this.CompraId = compraId;
            this.Valor = valor;
            this.StatusCota = StatusCota.Disponivel;
        }

        // to EF
        protected Cota() { }

        public int Numero { get; private set; }
        public decimal Valor { get; private set; }
        public StatusCota StatusCota { get; private set; }
        public Guid CompraId { get; private set; }

        public virtual Compra Compra { get; set; }

    }
}
