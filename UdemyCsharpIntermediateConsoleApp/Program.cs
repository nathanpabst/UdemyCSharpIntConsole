using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var person = Person.Parse("Nathan");
            person.Introduce("Nicole");

            var customer = new Customer(1, "Nicole");
            var order = new Order();

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }
    }
}

//NOTES:
//object initializer: a syntax for quickly initializing an object without the need to call the constructor
//ex: var person = new Person {FirstName = "Nathan", LastName = "Pabst"};