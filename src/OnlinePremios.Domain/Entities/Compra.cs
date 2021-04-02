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

            this.ClienteId = clienteId;
            this.DataCompra = dataCompra;
            this.QtdeCotas = qtdeCotas;
            this.StatusCompra = StatusCompra.AguardandoPagamento;
            _ = new List<CotaItem>();
        }

        // to EF
        public Compra() { }

        public DateTime DataCompra { get; private set; }
        public int QtdeCotas { get; set; }
        public StatusCompra StatusCompra { get; set; } 

        public Guid ClienteId { get; private set; }
        public virtual Cliente Cliente { get; set; }

        // Collections
        public IEnumerable<CotaItem> CompraItens { get; set; }


    }
}
