using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var adultPackageBuilder = new AdultPackageBuilder();
            SweetShop obj1 = new SweetShop(adultPackageBuilder);
            obj1.CreatePackage();
            var adultPackage = obj1.GetPackage();
            Console.WriteLine("Adult package has {0} sweets and {1} savouries.", adultPackage.Sweets, adultPackage.Savouries);
           var childPackageBuilder = new ChildPackageBuilder();            
           SweetShop obj2 = new SweetShop(childPackageBuilder);
            obj2.CreatePackage();
            var childPackage = obj2.GetPackage();            
           Console.WriteLine("Child package has {0} sweets and {1} savouries.", childPackage.Sweets, childPackage.Savouries);
            Console.ReadKey();
        }
    }
}
