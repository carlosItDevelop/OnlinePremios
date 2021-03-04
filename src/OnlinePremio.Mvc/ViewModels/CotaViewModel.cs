using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class CotaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Número")]
        public int Numero { get; private set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Valor")]
        public decimal Valor { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Status")]
        public StatusCota StatusCota { get; private set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Compra ID")]
        public Guid CompraId { get; private set; }

        public virtual Compra Compra { get; set; }
    }
}
