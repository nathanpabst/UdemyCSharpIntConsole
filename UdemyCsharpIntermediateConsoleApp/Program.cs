using System;
using System.IO;
using Amazon;

namespace UdemyCsharpIntermediateConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Shape shape = new Text();
            //downcasting the shape object. '(Text) shape' converts shape to text
            Text text = (Text)shape;
            //upcasting is implicit. we can convert a object reference to it's base class.
            //you can use downcasting to convert an object to a more specific type
            //...by using an explicit cast or by using the 'as' keyword'.
            //UseDbMigrator();
            //UseText();
            //UseCookie();
            //UseParams();
            //UsePerson();
            //UseCustomer();
        }

        private static void UseDbMigrator()
        {
            //ex. of using Composition...loose coupling and more flexibility than Inheritance
            var dbMigrator = new DbMigrator(new Logger());
            var logger = new Logger();
            var installer = new Installer(logger);

            dbMigrator.Migrate();
            installer.Install();
        }

        private static void UseText()
        {
            //FROM: upcasting and downcasting section
            Text text = new Text();
            //upcasting: text & shape are both references to the same object in memory.
            Shape shape = text;

            text.Width = 200;
            shape.Width = 100;

            Console.WriteLine(text.Width);
            //_________________________
            //var text = new Text();
            //text.Width = 100;
            //text.Copy();
        }

        private static void UseCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Frogger";
            Console.WriteLine(cookie["name"]);
        }

        private static void UseCustomer()
        {
            var customer = new Customer();

            customer.Promote();
        }

        private static void UsePerson()
        {
            var person = new Person(new DateTime(1984, 1, 3));
            Console.WriteLine(person.Age);

            //person.SetBirthday(new DateTime(1984, 1, 3));
            //Console.WriteLine(person.GetBirthday());

            //var person = Person.Parse("Nathan");
            //person.Introduce("Nicole");
        }

        private static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2));
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4));
            Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5, 6 }));
        }

        private static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                point.Move(null);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); //returns (40, 60)

                point.Move(100, 200);
                Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y); //returns (100, 200)
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}

//NOTES:
//object initializer: a syntax for quickly initializing an object without the need to call the constructor
//ex: var person = new Person {FirstName = "Nathan", LastName = "Pabst"};