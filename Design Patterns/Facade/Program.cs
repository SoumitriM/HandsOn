using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Drawing the shapes : ");
            var ShapeMaker = new ShapeMaker();
            ShapeMaker.DrawCircle();
            ShapeMaker.DrawRectangle();
            ShapeMaker.DrawSquare();
            Console.ReadKey();
        }
    }
}
