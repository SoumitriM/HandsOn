using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class AudiHeadlight : Headlight
    {
        public override string ToString()
        {
            return("Audi Headlight created...");
        }
    }
}
