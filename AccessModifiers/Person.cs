using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace AccessModifiers
{
    public class Person
    {
        public string Name { get; set; }
        public string userName { get; set; }
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }
        
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Now - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
    }
}
