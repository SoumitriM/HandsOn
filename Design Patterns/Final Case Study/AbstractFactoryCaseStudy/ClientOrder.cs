using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
    public class ClientOrder
    {
        AbstractFactory factory;
        public ClientOrder(AbstractFactory _factory)
        {
            factory = _factory;
        }

        public void BuildElectronicOrder(Channel channel)
        {


            factory.TakeElectronicOrder(channel, ProductType.Electronic);
        }
        public void BuildFurnitureOrder(Channel channel)
        {


            factory.TakeFurnitureOrder(channel, ProductType.Furniture);
        }
        public void BuildToyOrder(Channel channel)
        {


            factory.TakeToyOrder(channel, ProductType.Toy);

        }

    }
}
