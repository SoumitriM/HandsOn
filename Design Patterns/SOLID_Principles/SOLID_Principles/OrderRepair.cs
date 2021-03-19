using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class OrderRepair: IOrderRepair
    {
        public void ProcessOrder(string modelName)
        {
            Console.WriteLine("{0} order has been updated..", modelName);
        }
    }
}
