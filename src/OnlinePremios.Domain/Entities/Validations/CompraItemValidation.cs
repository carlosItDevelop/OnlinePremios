using FluentValidation;

namespace OnlinePremios.Domain.Entities.Validations
{
    public class CompraItemValidation : AbstractValidator<CotaItem>
    {
        public CompraItemValidation()
        {
            RuleFor(f => f.Numero)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.CompraId)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }
}
