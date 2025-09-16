using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Car: Vehicle
    {
        public Car(string regNumber)
            : base(regNumber)
        {
            Console.WriteLine($"Car is being initialized. {regNumber}");
        }
    }
}
