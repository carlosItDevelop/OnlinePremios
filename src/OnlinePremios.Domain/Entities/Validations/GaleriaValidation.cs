using FluentValidation;

namespace OnlinePremios.Domain.Entities.Validations
{


    public class GaleriaValidation : AbstractValidator<Galeria>
    {
        public GaleriaValidation()
        {
            RuleFor(f => f.SorteioId)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

        }
    }

}
