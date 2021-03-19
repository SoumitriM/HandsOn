using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class MercedesHeadlight : Headlight
    {
        public override string ToString()
        {
            return ("Mercedes Headlight created...");
        }
    }
}
