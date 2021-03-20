using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase2
{
    class JohnObserver : INotificationObserver
    {
        private string _name;
        public JohnObserver()
        {
            _name = "John";
        }
        public string Name
        {
            get => _name;
        }
        public void OnServerDown()
        {
            Console.WriteLine("{0} has recieved the notification..",_name);
        }
    }
    class ConcreteObserver : INotificationObserver
    {
        private string _name;
        public ConcreteObserver(string name)
        {
            _name = name;
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
