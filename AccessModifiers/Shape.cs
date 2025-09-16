using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("Drawing a shape");
        }

    }

    public class Circle : Shape1
    {
        public override void Draw1()
        {
            Console.WriteLine($"Draw a Circle:");
        }
    }

    public class Rectangle : Shape1
    {
        public override void Draw1()
        {
            Console.WriteLine($"Draw a Rectangle:");
        }
    }

    public class Shape1
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public virtual void Draw1()
        {
          
        }
    }
}
