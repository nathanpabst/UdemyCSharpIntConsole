using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Calculator
    {
        //smelly method overloading example...
        //public int Add(int n1, int n2) { }

        //public int Add(int n1, int n2, int n3) { }

        //public int Add(int n1, int n2, int n3, int n4) { }
        //issue...if you wanted to add 10 numbers together, you'd have to overload the Add method 10 times. #smellyCode #inefficient

        //refactoring the Add method
        //instead of overloading the add method to include all possible variations, we declare it once and have it rec a parameter of type array

        //public int Add(int[] numbers) { }
        //declaration of the add method...
        //private var result = calculator.Add(new int[] {1, 2, 3, 4});
        //issue here...each time you want to pass a number of arguments to the Add method..
        //we have to create and initialize an array.
        //further refactored using the params modifier...
        //By using the params keyword, you can specify a method parameter that takes a variable number of arguments. The parameter type must be a single-dimensional array. No additional parameters are permitted after the params keyword in a method declaration, and only one params keyword is permitted in a method declaration.
        //use params when your method will have a varying number of parameters
        //public int Add(params int[] numbers) { }
        //NOTE: using params, we don't have to create and initialize a new array
        //private var result = calculator.Add(1, 2, 3, 4);
    }
}