using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudy2
{
    class AdminTeam1 :INotificationObserver
    {
        private string _name;
        public AdminTeam1()
        {
            _name = "Admin1";
        }
        public string Name
        {
            get => _name;
        }
        public void OnEventNotification()
        {
            Console.WriteLine("{0} has recieved notification about the new event..", Name);
        }
    }
}
