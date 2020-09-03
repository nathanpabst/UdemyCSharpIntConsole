using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Amazon;

namespace UdemyCsharpIntermediateConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Boxing: the process of converting a value type instance to an object reference
            //With boxing and unboxing, the creation of the extra object results in a performance penalty
            //...it will be better to use a generic implementation, if one exists
            var list = new ArrayList();
            list.Add(1); //ArrayList accepts an object as an argument. boxing will occur
            list.Add("Stuff"); //string is a reference. no unboxing here.
            list.Add(DateTime.Today); //dateTime is a structure. structure is a value type, so boxing will occur

            var anotherList = new List<int>(); //creates a generic list of numbers
            anotherList.Add(); //receives an argument type of integer as opposed to object, which provides type-safety.
            //...no boxing will occur because internally, this stores a list of integers (not objects).
            var names = new List<string>();
            names.Add(); // receives an argument type of string, which provides type-safety

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