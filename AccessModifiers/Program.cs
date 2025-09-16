using System;

namespace AccessModifiers
{
    public class Program
    {

        static void Main (string[] args)
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(2000, 7, 27));
            Console.WriteLine(person.GetBirthdate());
        }

    }
}