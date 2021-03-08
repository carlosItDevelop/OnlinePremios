using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremio.Mvc.ViewModels
{
    public class ProdutoViewModel
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

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [Display(Name = "Nome do Arquivo")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e (1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [Display(Name = "Descrição")]
        [StringLength(200, ErrorMessage = "O campo {0} deve ter entre {2} e (1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório.")]
        [Display(Name = "Img URL")]
        [StringLength(2000, ErrorMessage = "O campo {0} deve ter entre {2} e (1} caracteres", MinimumLength = 7)]
        public string ImgURL { get; set; }


        [DisplayName("Imagem do Produto")]
        public IFormFile ImagemUpload { get; set; } // Todo: Implementar apenas na ViewModel

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Galeria ID")]
        public Guid GaleriaId { get; set; }
        public virtual GaleriaViewModel Galeria { get; set; }

    }
}
