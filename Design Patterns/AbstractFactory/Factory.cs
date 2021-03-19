using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public abstract class Factory
    {
        public abstract Headlight MakeHeadlight();
        public abstract Tire MakeTire();
    }
}
