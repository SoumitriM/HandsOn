using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeCaseStudy.Program;

namespace PracticeCaseStudy
{


    public class ConcreteCarFactory : CarFactory
    {
        

        public void MakeLuxuryCar(Location location, CarType carType)
        {
            new LuxuryCar(carType, location);
        }

        public void MakeMicroCar(Location location, CarType carType)
        {

            new MicroCar(carType, location);
        }

        public void MakeMiniCar(Location location, CarType carType)
        {

            new MiniCar(carType, location);
        }
    }
}
