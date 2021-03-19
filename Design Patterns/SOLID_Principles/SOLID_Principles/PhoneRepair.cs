using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles
{
    public class PhoneRepair:IPhoneRepair
    {
        public void ProcessPhoneRepair(string modelName)
        {
            Console.WriteLine("{0} phone will be repaired..", modelName);
        }
    }
}
