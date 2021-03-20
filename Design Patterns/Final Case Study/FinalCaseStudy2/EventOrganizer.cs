using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudy2
{
    class EventOrganizer :INotificationService
    {
        private List<INotificationObserver> Observers;
        public EventOrganizer()
        {
            Observers = new List<INotificationObserver>();

        }
        public void AddSubscriber(INotificationObserver observer)
        {
            Observers.Add(observer);
            Console.WriteLine("{0} has subscribed..",observer.Name);

        }
        public void RemoveSubscriber(INotificationObserver observer)
        {
            Observers.Remove(observer);
            Console.WriteLine("{0} has unsubscribed..", observer.Name);
        }
        public void NotifySubscriber()
        {
            foreach(var observer in Observers)
               observer.OnEventNotification();
        }
    }
}
