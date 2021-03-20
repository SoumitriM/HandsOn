using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new MessageSubscriber1();
            var s2 = new MessageSubscriber2();

            var p = new MessagePublisher();
            p.Attach(s1);
            p.Attach(s2);

            p.NotifyUpdate(new Message("Hello this is our first message...."));
            p.Detach(s1);
            p.NotifyUpdate(new Message("This is our second message...."));
            Console.ReadKey();
        }
    }
}