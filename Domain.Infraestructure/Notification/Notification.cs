﻿using System.Collections.Generic;
using System.Linq;

namespace Domain.Infraestructure.Notification
{
    public class Notification : INotification
    {
        private List<string> _notifications;

        public Notification() 
        {
            this._notifications = new List<string>();
        }

        public void Add(string message)
        {
            this._notifications.Add(message);
        }

        public bool IsNotifications()
        {
            return this._notifications.Any();
        }

        public List<string> ListAll()
        {
            return this._notifications;
        }
    }
}
