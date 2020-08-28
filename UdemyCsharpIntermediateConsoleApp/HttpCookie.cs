using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    internal class HttpCookie
    {
        //Indexers: a way to access elements in a class that represents a list of values.
        //Example: [0] within var array = new int[5]; array[0] = 1;
        //An indexer is declared in the same manner a property is declared. instead of an identifier, use the 'this' keyword.
        //Ex...
        //public string this[string key]{ get; set; } // 'key' represents the type of indexer

        //Dictionary: a data structure/type that resides in System.Collections.Generic. Dictionaries use a hash table to store data.
        //Hash Table: an extremely fast way to look up an item by its key.
        //use a list when you need to access an object by it's index || use a dictionary when you need to access an object by it's key.

        private Dictionary<string, string> _dictionary;

        public HttpCookie()
        {
            _dictionary = new Dictionary<string, string>();
        }

        //declaring an indexer..
        public string this[string key]
        {
            get => _dictionary[key];
            set => _dictionary[key] = value;
        }
    }
}