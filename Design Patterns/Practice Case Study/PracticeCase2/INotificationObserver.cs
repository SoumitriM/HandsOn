using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCase2
{
    interface INotificationObserver
    {
        string Name { get; }
        void OnServerDown();
    }
}
