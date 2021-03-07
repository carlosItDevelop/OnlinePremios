using Microsoft.AspNetCore.Mvc;
using OnlinePremios.Domain.Interfaces.Notify;

namespace OnlinePremio.Mvc.Controllers
{
    public abstract class BaseController : Controller
    {
        private readonly INotificator _notificator;

        protected BaseController(INotificator notificator)
        {
            _notificator = notificator;
        }

        protected bool OperacaoValida()
        {
            return !_notificator.HasNotification();
        }
    }
}
