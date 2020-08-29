using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    //Coupling: a measure of the interconnectedness between classes and subsystems
    //i.e. a change in one class (class A), which contains dependencies on other classes (class B & class C), may affect the dependent classes (B&C)
    //considered a tightly coupled application...classes are too intertwined and dependent upon each other --Bad policy
    //Loosely Coupled--ideal policy--changes to any given class are isolated and do not affect other parts of the application.
    //How to design a loosely coupled class system/application...
    //Encapsulation...details are hidden to the other classes

    //The relationship between classes...
    //Inheritance: A kind of relationship between two classes that allows one to inherit code from the other. Considered an 'Is-A' relationship.
    //EX. a 'car' is a vehicle
    //Benefits: code re-use & polymorphic behavior

    //Composition: A kind of relationship between two classes that allows one to contain the other. Considered a 'Has-A' relationship
    //EX. a 'car' has an Engine
    //Benefits of Composition..code re-use, flexibility, a means to designing loose-coupled applications

    //Interfaces
    public class PresentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object was copied to clipboard.");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicated.");
        }
    }
}