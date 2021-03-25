using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(int numero, decimal valor)
        {
            this.Numero = numero;
            this.Valor = valor;
            this.StatusCota = StatusCota.Disponivel;
        }

        /// <summary>
        /// Ess construto é para adiconar cotas no Sorteio
        /// </summary>
        /// <param name="numero">Numeração sequancia das cotas</param>
        /// <param name="status">Status Inciial da cota</param>
        public Cota(int numero = 0)
        {
            this.Numero = numero;

        }
        // to EF
        public Cota() { }

        public int Numero { get; set; }
        public decimal Valor { get; set; }
        public StatusCota StatusCota { get; set; }
        public Guid CompraId { get; set; }

        public virtual Compra Compra { get; set; }
        public virtual Sorteio Sorteio { get; set; }

    }
}

       