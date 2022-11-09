using System.Collections.Generic;

namespace Domain.Infraestructure.Notification
{
    public interface INotification
    {
        bool IsNotifications();
        void Add(string message);
        List<string> ListAll();
    }
}
