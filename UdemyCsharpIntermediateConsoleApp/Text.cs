using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("Added a link to " + url);
        }
    }
}