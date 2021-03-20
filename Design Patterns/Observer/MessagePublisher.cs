using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer
{
    public class MessagePublisher : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("One subscriber subscribed..");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("One subscriber unsubscribed..");
        }

        public void NotifyUpdate(Message m)
        {
            foreach (var observer in _observers)
            {
                observer.Update(m);
            }
        }
    }
}