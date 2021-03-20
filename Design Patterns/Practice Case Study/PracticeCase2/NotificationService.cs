using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase2
{
    class NotificationService : INotificationService
    {
        private List<INotificationObserver> Observers;
        public NotificationService()
        {
            Observers = new List<INotificationObserver>();
        }
        public void AddSubscriber(INotificationObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("Current Subscribers: ");
            foreach (var ob in Observers)
                Console.WriteLine(ob.Name);
        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("Updated Subscriber's List");
            foreach (var ob in Observers)
                Console.WriteLine(ob.Name);
        }
        public void NotifySubscriber()
        {
            foreach (var ob in Observers)
                ob.OnServerDown();
        }
    }
}
