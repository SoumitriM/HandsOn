using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PracticeCaseStudy.Program;

namespace PracticeCaseStudy
{
    public interface CarFactory
    {
        void MakeMicroCar(Location location, CarType carType);
        void MakeMiniCar(Location location, CarType carType);
        void MakeLuxuryCar(Location location, CarType carType);
    }
}
