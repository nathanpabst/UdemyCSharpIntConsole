using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var text = new Text();
            text.Width = 100;
            text.Copy();
            //UseCookie();
            //UseParams();
            //UsePerson();
            //UseCustomer();
        }

        private static void UseCookie()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Frogger";
            Console.WriteLine(cookie["name"]);
        }

        private static void UseCustomer()
        {
            var customer = new Customer(1, "Nicole");
            customer.Orders.Add(new Order());
            customer.Orders.Add(new Order());

            customer.Promote();

            Console.WriteLine(customer.Orders.Count);

            //var order = new Order();
            //Console.WriteLine(customer.Id);
            //Console.WriteLine(customer.Name);
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