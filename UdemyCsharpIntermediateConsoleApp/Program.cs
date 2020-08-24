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