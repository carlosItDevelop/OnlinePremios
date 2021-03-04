using OnlinePremios.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlinePremios.Domain.Interfaces
{
    public interface INotificator
    {
        bool HasNotification();
        List<Notification> GetNotifications();
        void Handle(Notification notification);
    }
}
