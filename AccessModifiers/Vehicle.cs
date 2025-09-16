using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
   public class Vehicle
    {
        private readonly string _registrationNumber;

        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is being initialized");
        //}

        public Vehicle(string regNumber)
        {
            _registrationNumber = regNumber;

            Console.WriteLine($"Vehicle is being initialized: {regNumber}");
        }

    }
}
