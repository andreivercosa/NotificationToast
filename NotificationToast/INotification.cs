using System;
namespace NotificationToast
{
    public interface INotification
    {
        void Demorado(string msg);
        void Rapido(string msg);
    }
}
