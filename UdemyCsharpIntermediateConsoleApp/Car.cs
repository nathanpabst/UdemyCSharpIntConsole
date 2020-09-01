using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Car : Vehicle
    {
        public Car(string registrationNumber)
        : base(registrationNumber)
        {
            Console.WriteLine("Car initialized here. {0}", registrationNumber);
        }
    }
}