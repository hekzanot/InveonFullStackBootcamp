using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciplesDemos
{
    //public class EmailService
    //{
    //    public void SendEmail(string message)
    //    {
    //        Console.WriteLine($"Email send: {message}");
    //    }
    //}

    //public class NotificationManager
    //{
    //    private EmailService _emailService = new EmailService();

    //    public void Notify(string message)
    //    {
    //        _emailService.SendEmail(message);
    //    }
    //}

    public interface INotifService
    {
        void Send(string message);
    }

    public class EmailService : INotifService
    {
        public void Send(string message)
        {
            Console.WriteLine($"Email sent: {message}");
        }
    }




    public class NotificationManager
    {
        private readonly INotifService _notificationService;



        public NotificationManager(INotifService notificationService)
        {
            _notificationService = notificationService;
        }

        public void Notify(string message)
        {
            _notificationService.Send(message);
        }
}





}
