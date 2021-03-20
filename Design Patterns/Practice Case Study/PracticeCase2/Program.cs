using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase2
{
    class Program
    {
        static void Main(string[] args)
        {
            var John = new ConcreteObserver("John");
            var Steve = new ConcreteObserver("Steve");
            var notificationService = new NotificationService();
            notificationService.AddSubscriber(John);
            notificationService.AddSubscriber(Steve);
            notificationService.NotifySubscriber();
            notificationService.RemoveSubscriber(Steve);
            //Console.WriteLine("Steve has been removed from the subscriber's list.");
            //Console.WriteLine("Notifying subscribers again...");
            //notificationService.NotifySubscriber();
            Console.ReadKey();
        }
    }
}
