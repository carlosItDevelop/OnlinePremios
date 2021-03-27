using FluentValidation;


namespace OnlinePremios.Domain.Entities.Validations
{

    public class CotaValidation : AbstractValidator<Cota>
    {
        public CotaValidation()
        {
            RuleFor(f => f.Numero)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.Valor)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.StatusCota)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.SorteioId)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");


        }
    }

}
