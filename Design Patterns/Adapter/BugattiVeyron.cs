using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class BugattiVeyron: Movable 
    {
        public double getSpeed()
        {
            return 268;
        }
        public double getPrice()
        {
            return 50;
        }
    }
}
