using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Customer
    {
        //declaration of fields Id & Name
        public int Id;

        public string Name;

        //example of initializing the orders field directly without creating the constructor. with this approach,
        //..the Orders field will always be initialized to an empty list regardless of which constructor is called
        //public readonly List<Order> Orders = new List<Order>();

        //fields using the readonly modifier ensure the field is only assigned once
        //readonly List<Order> Orders = new List<Order>();

        //implementation type constructors
        //public Customer() // default/parameterless constructor
        //{
        //}

        //overloaded constructors
        //public Customer(int id) //: this()  //using ': this()'...when the constructor is called, it will first look to the parameterless constructor and initialize the Orders field
        //{
        //    this.Id = id;
        //}

        //public Customer(int id, string name) : this(id) // the 'this()' keyword specifies which constructor we want to pass control to. not best practice...complicated and hard to maintain.
        //{
        //    this.Name = name;
        //}

        //Method
        public void Promote()
        {
            var rating = CalculateRating();

            //the following line is a defect and when the method is used will clear out any existing orders.
            //Orders is initialized above and does not need to be re-initialized.
            //To correct this, we need to add the 'readonly' modifier in the declaration or constructor
            //Orders = new List<Order>();
            // ...
        }

        public int CalculateRating()
        {
            return 0;
        }
    }
}