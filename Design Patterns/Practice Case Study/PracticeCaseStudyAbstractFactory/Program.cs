using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudy
{
    public class Program
    {
            static void Main(string[] args)
            {
                CarFactory carFactory = new ConcreteCarFactory();
                CarClient carClient = new CarClient(carFactory);
                carClient.BuilderMicroCar(Location.USA);

                carClient.BuildMiniCar(Location.INDIA);

                carClient.BuildLuxuryCar(Location.DEFAULT);

                Console.ReadKey();
            }

            public enum CarType
            {
                MICRO, MINI, LUXURY
            }
            public enum Location
            {
                DEFAULT, USA, INDIA
            }
            public abstract class Car
            {
                public Car(CarType model, Location location)
                {
                    this.CarType = model;
                    this.Location = location;
                }

                public abstract void Construct();

                public CarType CarType { get; set; }
                public Location Location { get; set; }

                public override string ToString()
                {
                    return "CarModel - " + CarType.ToString() + ", located in " + Location.ToString();
                }
            }

          public  class LuxuryCar : Car
            {
                public LuxuryCar(CarType carType, Location location) : base(CarType.LUXURY, location)
                {
                    Construct();
                }
                public override void Construct()
                {
                    Console.WriteLine("Connecting to luxury car");
                    Console.WriteLine(base.ToString());
                }
            }



           public class MicroCar : Car
            {
                public MicroCar(CarType carType, Location location) : base(CarType.MICRO, location)
                {
                    Construct();
                }
                public override void Construct()
                {
                    Console.WriteLine("Connecting to Micro car");
                    Console.WriteLine(base.ToString());
                }
            }


           public  class MiniCar : Car
            {
                public MiniCar(CarType carType, Location location) : base(CarType.MINI, location)
                {
                    Construct();
                }
                public override void Construct()
                {
                    Console.WriteLine("Connecting to Mini car");
                    Console.WriteLine(base.ToString());
                }
            }
        }

    }

