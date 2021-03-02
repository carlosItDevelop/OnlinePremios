using OnlinePremios.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePremios.Domain.Entities
{
    public class Cota : EntityBase
    {
        public Cota(){}

        public int Numero { get; private set; }
        public int Status { get; private set; }
        public Guid CompraId { get; set; }
        public virtual Compra Compra { get; private set; }

    }
}
