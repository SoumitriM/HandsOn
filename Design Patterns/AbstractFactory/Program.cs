using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the car brand: (Audi/Mercedes)");
            string brand = Console.ReadLine();
            var obj = new Program();
            var factory = obj.GetFactory(brand);
            var order = new ClientCar(factory);
            Console.WriteLine(order.getHeadlight());
            Console.WriteLine(order.getTire());
            Console.ReadKey();
        }
        public Factory GetFactory(string brand)
        {
            if (brand == "Audi") return new AudiFactory();
            else if (brand == "Mercedes") return new MercedesFactory();
            else return null;
        }
    }
}
