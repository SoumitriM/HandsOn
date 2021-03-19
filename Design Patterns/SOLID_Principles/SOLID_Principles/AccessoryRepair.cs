using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    class AccessoryRepair: IAccessoryRepair
    {
        public void ProcessAccessoryRepair(string accessoryName)
        {
            Console.WriteLine("The {0} of your phone will be repaired..", accessoryName);
        }
    }
}
