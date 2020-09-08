using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Text : Shape
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public override void Draw()
        {
            Console.WriteLine("draw text.");
        }
    }
}