using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface Movable //returns mph and USD
    {
        double getSpeed();
        double getPrice();
    }
}
