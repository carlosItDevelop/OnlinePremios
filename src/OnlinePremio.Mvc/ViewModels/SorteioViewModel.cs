using OnlinePremios.Domain.Entities;
using OnlinePremios.Domain.Enum;
using System;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class SorteioViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Display(Name = "Data do Cadastro")]
        public DateTime? DataCadastro { get; set; }
        [Display(Name = "Data de Atualização")]
        public DateTime? DataAtualizacao { get; set; }
        [Display(Name = "Usuário da Atualização")]
        public Guid? UserUpdate { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Número")] 
        public int Numero { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data Inválida!")]
        [Display(Name = "Data do Sorteio")] 
        public DateTime DataSorteio { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.DateTime, ErrorMessage = "Data Inválida!")]
        [Display(Name = "Data Inicial")]
        public DateTime DataInicial { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [Display(Name = "Qtde de Cotas")]
        public int QtdeCotas { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Status")]
        public StatusSorteio StatusSorteio { get; set; }

        //[Required(ErrorMessage = "O campo {0} é obrigatório")]
        //[Display(Name = "Galeria ID")]
        //public Guid GaleriaId { get; set; }  // Todo: Avaliar este campo, pois tb tem em produto

        //public virtual Galeria Galeria { get; set; }

    }
}
