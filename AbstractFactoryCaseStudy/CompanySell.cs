using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AbstractFactoryCaseStudy.Program;

namespace AbstractFactoryCaseStudy
{
   public class CompanySell
    {
        ComapanyFactory companyFactory1;
        public CompanySell(ComapanyFactory companyFactory)
        {
            companyFactory1 = companyFactory;
        }

        public void BuildElectronicOrder(Channel channel)
        {


            companyFactory1.TakeElectronicOrder(channel, ProductType.Electronic);
        }
        public void BuildFurnitureOrder(Channel channel)
        {


            companyFactory1.TakeFurnitureOrder(channel, ProductType.Furniture);
        }
        public void BuildToyOrder(Channel channel)
        {


            companyFactory1.TakeToyOrder(channel, ProductType.Toy);

        }

    }
}
