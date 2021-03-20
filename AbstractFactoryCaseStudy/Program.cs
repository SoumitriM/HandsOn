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
            ComapanyFactory comapanyFactory = new ConcreteComapnyFactory();
            CompanySell companySell = new CompanySell(comapanyFactory);
            companySell.BuildElectronicOrder(Channel.Ecommerce);
            companySell.BuildFurnitureOrder(Channel.Ecommerce);
            companySell.BuildToyOrder(Channel.Tele);

           

            Console.ReadKey();
        }

        public enum ProductType
        {
            Electronic, Furniture, Toy
        }
        public enum Channel
        {
            Ecommerce, Tele
        }
        public abstract class Order
        {
            public Order(ProductType productType, Channel channel)
            {
                this.ProductType = productType;
                this.Channel = channel;
            }

            public abstract void Construct();

            public ProductType ProductType { get; set; }
            public Channel Channel { get; set; }

            public override string ToString()
            {
                return "Product is  - " + ProductType.ToString() + ", order via " + Channel.ToString();
            }
        }

        public class ElectronicOrder : Order
        {
            public ElectronicOrder(ProductType productType, Channel channel) : base(ProductType.Electronic, channel)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Ordering a electronic product");
                Console.WriteLine(base.ToString());
            }
        }

        public class FurnitureOrder : Order
        {
            public FurnitureOrder(ProductType productType, Channel channel) : base(ProductType.Furniture, channel)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Ordering a Furniture");
                Console.WriteLine(base.ToString());
            }
        }

        public class ToyOrder : Order
        {
            public ToyOrder(ProductType productType, Channel channel) : base(ProductType.Toy, channel)
            {
                Construct();
            }
            public override void Construct()
            {
                Console.WriteLine("Ordering a Toy");
                Console.WriteLine(base.ToString());
            }
        }

       
    }

}

