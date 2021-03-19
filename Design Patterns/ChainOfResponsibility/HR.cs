using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class HR : ILeaveRequestHandler
    {
        private ILeaveRequestHandler _nextHandler;

        public ILeaveRequestHandler NextHandler
        {
            get => _nextHandler;
            //set => _nextHandler = null;
        }
        public void HandleRequest(LeaveRequest request)
        {
            if (request.LeaveDays > 5)
            {
                Console.WriteLine("Leave Request approved by HR..");
                _nextHandler = null;
            }
        }
    }
}
