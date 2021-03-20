using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Observer
{
    public class MessageSubscriber2 : IObserver
    {
        public void Update(Message m)
        {
            Console.WriteLine("Subscriber2 recieved the message : " + m.GetMessageContent());
        }
    }
}