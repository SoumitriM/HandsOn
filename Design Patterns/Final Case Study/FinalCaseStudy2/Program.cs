using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudy2
{
    class Program
    {
        static void Main(string[] args)
        {
            var adminTeam1 = new AdminTeam1();
            var adminTeam2 = new AdminTeam2();
            var eventOrganizer = new EventOrganizer();
            eventOrganizer.AddSubscriber(adminTeam1);
            eventOrganizer.AddSubscriber(adminTeam2);
            eventOrganizer.NotifySubscriber();
            eventOrganizer.RemoveSubscriber(adminTeam1);
            Console.ReadKey();
        }
    }
}
