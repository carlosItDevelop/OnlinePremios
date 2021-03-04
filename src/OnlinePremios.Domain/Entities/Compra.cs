using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Compra : EntityBase
    {

        protected Compra(Guid clienteId, DateTime dataCompra, int qtdeCotas)
        {

            // Todo: Validar id != null, dataValida e qtde > 0;
            // Setar StatusCompra

            this.ClienteId = clienteId;
            this.DataCompra = dataCompra;
            this.QtdeCotas = qtdeCotas;
            this.Cotas = new List<Cota>();
        }

        public Guid ClienteId { get; private set; }
        public DateTime DataCompra { get; private set; }
        public int QtdeCotas { get; set; }
        public StatusCompra StatusCompra { get; set; } // Todo: Transformar em Enum e usar Description

        public virtual ICollection<Cota> Cotas { get; set; }

    }
}
