using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremios.Domain.Entities
{
    public class CompraItem : EntityBase
    {
        [Key]
        public string ItemId { get; set; }
        public int Numero { get; set; }
        public Guid CompraId { get; set; }
        public System.DateTime DateCriação { get; set; }
        public Guid CotaId { get; set; }
        public virtual Compra Compra { get; set; }
        public virtual Cota Cota { get; set; }


    }
}

       