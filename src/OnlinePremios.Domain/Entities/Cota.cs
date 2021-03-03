using OnlinePremios.Domain.Core;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(int numero, Guid compraId)
        {
            this.Numero = numero;
            this.CompraId = compraId;
            // Setar StatusCota
        }

        public int Numero { get; private set; }
        public int StatusCota { get; private set; }
        public Guid CompraId { get; set; }
        public virtual Compra Compra { get; private set; }

    }
}
