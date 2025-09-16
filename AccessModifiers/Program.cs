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

            //This Code is for Text and PresentationObject
            var text = new Text();
            text.Duplicate();
            text.FontName = "Arial";
            text.FontSize = 12;
            text.Width = 100;
            text.height = 150;
            text.Copy();



        }

    }
}