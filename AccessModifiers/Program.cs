using System;

namespace AccessModifiers
{
    public class Program
    {

        static void Main (string[] args)
        {
            var person = new Person(new DateTime(2000, 12, 27));
            Console.WriteLine(person.Age);
            //
        }

    }
}