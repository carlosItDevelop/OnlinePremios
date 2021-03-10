using FluentValidation;
using System;

namespace OnlinePremios.Domain.Entities.Validations
{
    public class CompraValidation : AbstractValidator<Compra>
    {
        public CompraValidation()
        {
            RuleFor(f => f.DataCompra)
                .NotNull().WithMessage("O campo {PropertyName} precisa ser fornecido");

            RuleFor(f => f.DataCompra)
                .LessThan(DateTime.Now)
                .WithMessage("A {PropertyName} não pode ser no tempo passado");

        }
    }
}
