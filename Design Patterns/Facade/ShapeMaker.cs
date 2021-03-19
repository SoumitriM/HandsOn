using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class ShapeMaker
    {
        private Circle _circle;
        private Rectangle _rectangle;
        private Square _square;
        public ShapeMaker()
        {
            _circle = new Circle();
            _rectangle = new Rectangle();
            _square = new Square();
        }
        public void DrawCircle()
        {
            _circle.Draw();
        }
        public void DrawRectangle()
        {
            _rectangle.Draw();
        }
        public void DrawSquare()
        {
            _square.Draw();
        }
    }
}
