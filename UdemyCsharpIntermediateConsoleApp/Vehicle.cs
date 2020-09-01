using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Vehicle
    {
        //Alt + Enter on the registrationNumber parameter in the constructor will introduce and initialize this field.
        private readonly string _registrationNumber;

        //the constructor of the base class is always executed first. i.e. the following cw from Vehicle will print first when the Car method is called.
        //default constructor
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle initialized here");
        //}

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;

            Console.WriteLine("Vehicle initialized here. {0}", registrationNumber);
        }
    }
}