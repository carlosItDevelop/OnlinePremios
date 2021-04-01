using OnlinePremios.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OnlinePremios.Mvc.ViewModels
{
    /// <summary>
    /// Todo: Preciso definir as raizes de agregações
    ///    Exemplo:
    ///    Cliente tem Compra, tem Pagamento(nem criei)
    ///    Compra tem Cota, Galeria, Produto...
    /// </summary>
    public class ClienteViewModel
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
        [StringLength(120, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }

        [DisplayName("Tipo")]
        public TipoPessoa TipoPessoa { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(255, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 5)]
        [DataType(DataType.EmailAddress,ErrorMessage = "Email Inválido!")]
        public string Email { get; set; }

        [DisplayName("Status")]
        public StatusCliente StatusCliente { get; set; }

        public virtual IEnumerable<CompraViewModel> Compras { get; set; }
    }
}
