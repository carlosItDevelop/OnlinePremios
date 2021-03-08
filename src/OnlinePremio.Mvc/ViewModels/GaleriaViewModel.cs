using OnlinePremios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class GaleriaViewModel
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



        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Sorteio ID")] 
        public Guid SorteioId { get; set; }
        
        public virtual SorteioViewModel Sorteio { get; set; }
        public virtual IEnumerable<ProdutoViewModel> Produtos { get; set; }

    }
}
