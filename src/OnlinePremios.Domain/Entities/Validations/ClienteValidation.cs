using FluentValidation;

namespace OnlinePremios.Domain.Entities.Validations
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(f => f.Nome)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Cpf)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Email)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");
             

        }
    }
}
