using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Entities
{
    public class Galeria : EntityBase
    {
        public Galeria()
        {

        }

        public Guid SorteioId { get; set; }
        public virtual Sorteio Sorteio { get; set; }
        public virtual ICollection<Produto> Produtos { get; set; }
    }
}