﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyCsharpIntermediateConsoleApp
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}