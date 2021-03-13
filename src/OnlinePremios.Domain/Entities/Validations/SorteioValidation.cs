using FluentValidation;
using System;

namespace OnlinePremios.Domain.Entities.Validations
{
    public class SorteioValidation : AbstractValidator<Sorteio>
    {

        public SorteioValidation()
        {
            RuleFor(f => f.Numero)
                    .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.DataInicial)
                    .LessThan(DateTime.Now)
                    .WithMessage("A {PropertyName} não pode ser no tempo passado");

            RuleFor(f => f.DataSorteio)
                    .NotNull()
                    .WithMessage("A {PropertyName} não pode ser nula.");

        }
    }
}
