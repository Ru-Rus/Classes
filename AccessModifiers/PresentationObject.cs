using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class  PresentationObject
    {
        public int Width { get; set; }
        public int height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Copying...");
        }

        public void Duplicate()
        {
            Console.WriteLine("Duplicating...");
        }

    }
}
