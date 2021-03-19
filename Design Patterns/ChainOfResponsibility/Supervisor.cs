using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Supervisor :ILeaveRequestHandler
    {
        private ILeaveRequestHandler _nextHandler;
       
        
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays < 4)
            {
                Console.WriteLine("Leave Request approved by Supervisor..");
                _nextHandler = null;
            }
            else
            {
                _nextHandler = new ProjectManager();
                _nextHandler.HandleRequest(request);
            }

        }
        public ILeaveRequestHandler NextHandler
        {
            get => _nextHandler;
            // set => _nextHandler = value;
        }

    }
}
