using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Galeria : EntityBase
    {
        public Galeria(Guid sorteioId)
        {
            this.SorteioId = sorteioId;
        }

        // to EF
        protected Galeria() { }

        public Guid SorteioId { get; private set; }
        public virtual Sorteio Sorteio { get; set; }
        public virtual IEnumerable<Produto> Produtos { get; set; }
    }
}