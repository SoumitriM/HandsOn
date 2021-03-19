using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var supervisor = new Supervisor();
            var projectManager = new ProjectManager();
            var hr = new HR();
            LeaveRequest request = new LeaveRequest();
            Console.WriteLine("Enter Employee Name: ");
            request.Employee = Console.ReadLine();
            Console.WriteLine("Enter Leave Days: ");
            request.LeaveDays = Convert.ToInt32(Console.ReadLine());
            supervisor.HandleRequest(request);
            Console.ReadKey();
        }
    }
}
