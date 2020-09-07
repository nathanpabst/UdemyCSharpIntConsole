using System;

namespace UdemyCsharpIntermediateConsoleApp
{
    //POLYMORPHISM: many forms
    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("draw a circle");
        }
    }
}