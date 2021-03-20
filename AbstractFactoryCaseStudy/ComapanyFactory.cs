using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    public interface ComapanyFactory
    {
        void TakeElectronicOrder(Channel channel, ProductType productType);
        void TakeFurnitureOrder(Channel channel, ProductType productType);
        void TakeToyOrder(Channel channel, ProductType productType);
    }
}
