﻿namespace OnlinePremios.Domain.Notifications
{
    public class Notification
    {
        public Notification(string mensagem)
        {
            Mensagem = mensagem;
        }

        public string Mensagem { get; }
    }
}
