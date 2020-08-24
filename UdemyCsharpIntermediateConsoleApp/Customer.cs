using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        //implementation type constructors
        public Customer() // default/parameterless constructor
        {
            Orders = new List<Order>();
        }

        //overloaded constructors
        public Customer(int id) : this() // using ': this()'...when the constructor is called, it will first look to the parameterless constructor and initialize the Orders field
        {
            this.Id = id;
        }

        public Customer(int id, string name) : this(id) // the 'this()' keyword specifies which constructor we want to pass control to. not best practice...complicated and hard to maintain.
        {
            this.Name = name;
        }
    }
}