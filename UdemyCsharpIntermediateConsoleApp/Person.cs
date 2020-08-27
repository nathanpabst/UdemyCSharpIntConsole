using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Person
    {
        //Property: a class member that encapsulates a getter/setter for accessing a field.
        //auto-implemented properties...
        public string Name { get; set; }

        public string UserName { get; set; }
        public DateTime Birthday { get; private set; }

        //constructor
        public Person(DateTime birthday)
        {
            Birthday = birthday;
        }

        //calculated properties...
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthday;
                var years = timeSpan.Days / 365;

                return years;
            }
        }

        //public void Introduce(string to)
        //{
        //    Console.WriteLine("Hi {0}, I am {1}", to, Name);
        //}

        //Signature of a method contains: Name, Number, and type of parameters.
        //public class Point
        //{
        //    public void Move(int x, int y)
        //    {
        //    }

        //    // overloading examples below. same method name but different signatures
        //    public void Move(Point newLocation) { }

        //    public void Move(Point newLocation, int speed)
        //    {
        //    }
        //}

        //public static Person Parse(string str)
        //{
        //    var person = new Person();
        //    person.Name = str;
        //    return person;
        //}
    }
}