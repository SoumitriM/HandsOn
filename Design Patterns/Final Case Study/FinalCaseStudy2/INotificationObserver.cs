using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCaseStudy2
{
    interface INotificationObserver
    {
        string Name { get; }
        void OnEventNotification();
    }
}
