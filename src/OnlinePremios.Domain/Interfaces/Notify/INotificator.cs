using OnlinePremios.Domain.Notifications;
using System.Collections.Generic;

namespace OnlinePremios.Domain.Interfaces.Notify
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
