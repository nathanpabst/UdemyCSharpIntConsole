using System;

namespace Amazon
{
    public class Customer
    {
        public int Id;
        public string Name;

        public void Promote()
        {
            //not best practice. creates coupling. use interface instead
            var calculator = new RateCalculator();
            var rating = calculator.Calculate(this);

            Console.WriteLine("promote logic changed.");
        }
    }
}