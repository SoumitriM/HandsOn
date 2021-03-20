using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryCaseStudy
{
    public class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory productFactory = new ConcreteFactory();
            ClientOrder order = new ClientOrder(productFactory);
            order.BuildElectronicOrder(Channel.Ecommerce_Website);
            order.BuildFurnitureOrder(Channel.Ecommerce_Website);
            order. BuildToyOrder(Channel.Telephone_Agent);
            Console.ReadKey();
        }

        public enum ProductType
        {
            Electronic, Furniture, Toy
        }
        public enum Channel
        {
            Ecommerce_Website, Telephone_Agent
        }
        public abstract class Order
        {
            public Order(ProductType productType, Channel channel)
            {
                this.ProductType = productType;
                this.Channel = channel;
            }

            public abstract void ProcessOrder();

            public ProductType ProductType { get; set; }
            public Channel Channel { get; set; }

            public override string ToString()
            {
                return ProductType.ToString() + " is ordered via " + Channel.ToString() + "...";
            }
        }

        public class ElectronicOrder : Order
        {
            public ElectronicOrder(ProductType productType, Channel channel) : base(ProductType.Electronic, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine(base.ToString());
            }
        }

        public class FurnitureOrder : Order
        {
            public FurnitureOrder(ProductType productType, Channel channel) : base(ProductType.Furniture, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine(base.ToString());
            }
        }

        public class ToyOrder : Order
        {
            public ToyOrder(ProductType productType, Channel channel) : base(ProductType.Toy, channel)
            {
                ProcessOrder();
            }
            public override void ProcessOrder()
            {
                Console.WriteLine(base.ToString());
            }
        }


    }

}

