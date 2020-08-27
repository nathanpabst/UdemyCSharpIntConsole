using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Person
    {
        //public string Name;
        private DateTime _birthday;

        public void SetBirthday(DateTime birthday)
        {
            _birthday = birthday;
        }

        public DateTime GetBirthday()
        {
            return _birthday;
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