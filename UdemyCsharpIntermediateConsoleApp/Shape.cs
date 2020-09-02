using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    //Upcasting: conversion from a derived class to a base class
    //UPCASTING: converting the object 'Circle' to it's base class reference i.e. 'Shape'. this is implicit and does not require conversion.
    //Object 'Circle' with the type of circle
    //Circle circle = new Circle();
    //Shape shape = circle;

    //Downcasting: conversion from a base class to a derived class
    //DOWNCASTING: EX. converting 'shape' to the 'Circle' object using an explicit cast.
    //Circle anotherCircle = (Circle)shape;

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
        }
    }
}