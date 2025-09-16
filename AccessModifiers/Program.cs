using System;

namespace AccessModifiers
{
    public class Program
    {

        static void Main (string[] args)
        {
            //// This code is for Birthday ( Properties )
            //var person = new Person(new DateTime(2000, 12, 27));
            //Console.WriteLine(person.Age);


            //// This code is for HttpCookie ( Indexers )
            //var cookie = new HttpCookie();
            //cookie["name"] = "Kaizer";
            //Console.WriteLine(cookie["name"]);

            ////This Code is for Text and PresentationObject ( Inheritance )
            //var text = new Text();
            //text.Duplicate();
            //text.FontName = "Arial";
            //text.FontSize = 12;
            //text.Width = 100;
            //text.height = 150;
            //text.Copy();

            ////This code is for Logger and DbMigrator and Installer ( Composition )
            //var dbMigrator = new DbMigrator(new Logger());

            //var logger = new Logger();
            //var installer = new Installer(logger);

            //dbMigrator.Migrate();

            //installer.Install();
            
            //This code is for Car and Vehicle ( Constructors and Inheritance )
            var car = new Car("ABC 123");

        }

    }
}