using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeCaseStudy.Program;

namespace PracticeCaseStudy
{
    public class CarClient 
      {
        CarFactory carFactory1;
        public CarClient(CarFactory carFactory)
        {
            carFactory1 = carFactory;
        }

        public void BuilderMicroCar(Location location)
        {
          

            carFactory1.MakeMicroCar(location, CarType.MICRO);
        }
        public void BuildMiniCar(Location location)
        {
           

            carFactory1.MakeMiniCar(location,CarType.MINI);
        }
        public void BuildLuxuryCar(Location location)
        {
          

            carFactory1.MakeLuxuryCar(location, CarType.LUXURY);

        }

    }
}
