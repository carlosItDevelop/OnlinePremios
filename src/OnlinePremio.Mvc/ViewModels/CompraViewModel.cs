using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class CompraViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime? DataCadastro { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime? DataAtualizacao { get; set; }
        [Display(Name = "Usuário da Atualização")]
        public Guid? UserUpdate { get; set; }





        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data Inválida!")]
        [Display(Name = "Data da Compra")]
        public DateTime DataCompra { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Qtde de Cotas")]
        public int QtdeCotas { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Status")]
        public StatusCompra StatusCompra { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Cliente ID")]
        public Guid ClienteId { get; set; }
        public virtual ClienteViewModel Cliente { get; set; }

        public virtual IEnumerable<CotaViewModel> Cotas { get; set; }
    }
}
