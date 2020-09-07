using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    //METHOD OVERRIDING: modifying the implementation of an inherited method.
    //METHOD OVERLOADING: method with the same name, but different signatures
    //VIRTUAL: using the virtual keyword in the base class, gives us the ability to change the implementation of the method in the derived class with the OVERRIDE keyword
    //virtual & override is an example of polymorphic behavior.

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
        }
    }
}