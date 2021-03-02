using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Compra : EntityBase
    {

        protected Compra(Guid compradorId, DateTime dataCompra, int qtdeCotas, int status)
        {

            // Todo: Validar id != null, dataValida e qtde > 0;

            this.CompradorId = compradorId;
            this.DataCompra = dataCompra;
            this.QtdeCotas = qtdeCotas;
            this.Cotas = new List<Cota>();
        }

        public Guid CompradorId { get; private set; }
        public DateTime DataCompra { get; private set; }
        public int QtdeCotas { get; set; }
        public int Status { get; set; } // Todo: Transformar em Enum e usar Description

        public virtual ICollection<Cota> Cotas { get; set; }

    }
}
