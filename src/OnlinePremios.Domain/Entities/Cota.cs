using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(int numero)
        {
            this.Numero = numero;
            this.StatusCota = StatusCota.Disponivel;
        }

        // to EF
        public Cota() { }

        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public StatusCota StatusCota { get; set; }
        public Guid SorteioId { get; set; }

        public virtual Sorteio Sorteio { get; set; }

    }
}
