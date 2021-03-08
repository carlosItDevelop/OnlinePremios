using OnlinePremios.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class CotaViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime? DataCadastro { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime? DataAtualizacao { get; set; }
        [Display(Name = "Usuário da Atualização")]
        public Guid? UserUpdate { get; set; }

        // =================================



        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Número")]
        public int Numero { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Status")]
        public StatusCota StatusCota { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Compra ID")]
        public Guid CompraId { get; set; }

        public virtual CompraViewModel Compra { get; set; }
    }
}
