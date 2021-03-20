using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class ClientCar 
    {
        Headlight headlight;
        Tire tire;
        public ClientCar(Factory Car)
        {
            headlight = Car.MakeHeadlight();
            tire = Car.MakeTire();
        }
        public string getHeadlight()
        {
            return headlight.ToString();
        }
        public string getTire()
        {
            return tire.ToString();
        }
    }
}
