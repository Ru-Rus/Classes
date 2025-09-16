using System;

namespace AccessModifiers
{
    public class Program
    {

        static void Main (string[] args)
        {
            // This code is for Birthday
            var person = new Person(new DateTime(2000, 12, 27));
            Console.WriteLine(person.Age);


            // This code is for HttpCookie
            var cookie = new HttpCookie();
            cookie["name"] = "Kaizer";
            Console.WriteLine(cookie["name"]);
        }

    }
}