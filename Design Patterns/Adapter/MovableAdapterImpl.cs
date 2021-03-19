using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class MovableAdapterImpl: MovableAdapter
    {
        private readonly Movable _luxuryCars;
        public MovableAdapterImpl(Movable luxuryCars)
        {
           _luxuryCars = luxuryCars;
        }
        public double getSpeed()
        {
            var speed = _luxuryCars.getSpeed() * 1.609344;
            return speed;
        }
        public double getPrice()
        {
            var euro = _luxuryCars.getPrice() * 0.84;
            return euro;
        }

    }
}
