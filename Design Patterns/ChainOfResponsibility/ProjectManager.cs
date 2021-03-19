using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler _nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get => _nextHandler;
            //set => _nextHandler = value;
        }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays < 6)
            {
                Console.WriteLine("Leave Request approved by Project Manager..");
                _nextHandler = null;
            }
            else
            {
                _nextHandler = new HR();
                _nextHandler.HandleRequest(request);
            }
        }
    }
}
