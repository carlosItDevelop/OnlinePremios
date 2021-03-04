using FluentValidation;
using FluentValidation.Results;
using OnlinePremios.Domain.Core;
using OnlinePremios.Domain.Interfaces;
using OnlinePremios.Domain.Notifications;

namespace OnlinePremios.Domain.Services
{
    public abstract class BaseService
    {
        private readonly INotificator _notificator;

        protected BaseService(INotificator notificador)
        {
            _notificator = notificador;
        }

        protected void Notificar(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
            {
                Notificar(error.ErrorMessage);
            }
        }

        protected void Notificar(string mensagem)
        {
            _notificator.Handle(new Notification(mensagem));
        }

        protected bool ExecutarValidacao<AbstractV, TEntity>(AbstractV validacao, TEntity entidade) 
            where AbstractV : AbstractValidator<TEntity> where TEntity : EntityBase
        {
            var validator = validacao.Validate(entidade);

            if (validator.IsValid) return true;

            Notificar(validator);

            return false;
        }
    }
}
