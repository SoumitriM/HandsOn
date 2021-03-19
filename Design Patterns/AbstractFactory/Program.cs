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
            Console.WriteLine(factory.MakeHeadlight());
            Console.WriteLine(factory.MakeTire());
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
