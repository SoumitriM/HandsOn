using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
   public  class ConcreteComapnyFactory : ComapanyFactory
    { 
     public void TakeElectronicOrder(Channel channel, ProductType productType)
    {
        new ElectronicOrder(productType, channel);
    }

    public void TakeFurnitureOrder(Channel channel, ProductType productType)
    {
        new FurnitureOrder(productType, channel);
    }

    public void TakeToyOrder(Channel channel, ProductType productType)
    {
        new ToyOrder(productType, channel);
    }
   
}
}


