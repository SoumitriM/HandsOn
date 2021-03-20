using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ChatMediator();
            var user1 = new BasicUser(mediator,"Soumitri");
            var user2 = new PremiumUser(mediator, "Ashita");
            var user3 = new PremiumUser(mediator, "Rashika");
            mediator.AddUser(user1);
            mediator.AddUser(user2);
            mediator.AddUser(user3);
            user1.SendMessage("Soumitri says Good Morning!");
            user2.SendMessage(" Ashita says Good Afternoon!");
            Console.ReadKey();
        }
    }
}
