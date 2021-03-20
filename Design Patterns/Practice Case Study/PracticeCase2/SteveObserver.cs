using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase2
{
    class SteveObserver : INotificationObserver
    {
        private string _name;
        public SteveObserver()
        {
            _name = "Steve";
        }
        public string Name
        {
            get => _name;
        }
        public void OnServerDown()
        {
            Console.WriteLine("{0} has recieved the notification..", _name);
        }
    }
}
