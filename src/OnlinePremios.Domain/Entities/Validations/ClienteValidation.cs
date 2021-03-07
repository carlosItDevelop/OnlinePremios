using FluentValidation;

namespace OnlinePremios.Domain.Entities.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(f => f.Nome)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            /*
             
                public string Nome { get; private set; }
                public string Cpf { get; private set; }
                public string Email { get; private set; }
                public StatusCliente StatusCliente { get; set; }

             */

        }
    }


}
