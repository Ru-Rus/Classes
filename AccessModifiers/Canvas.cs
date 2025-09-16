using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Canvass
    {
        public void DrawShapes(List<Shape1> Shapes1)
        {
            foreach (Shape1 shape1 in Shapes1)
            {
                shape1.Draw1();
            }
        }
    }
}
