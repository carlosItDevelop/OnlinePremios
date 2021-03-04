using OnlinePremios.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlinePremios.Domain.Notifications
{
    public class Notificator : INotificator
    {
        private List<Notification> _notificacoes;

        public Notificator()
        {
            _notificacoes = new List<Notification>();
        }

        public void Handle(Notification notificacao)
        {
            _notificacoes.Add(notificacao);
        }

        public List<Notification> GetNotifications()
        {
            return _notificacoes;
        }

        public bool HasNotification()
        {
            return _notificacoes.Any();
        }
    }
}
