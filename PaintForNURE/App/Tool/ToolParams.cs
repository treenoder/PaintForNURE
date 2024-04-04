using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForNURE.App.Tool
{
    internal class ToolParams(Point startPoint, Point lastPoint, Point currentPoint, Color color, int size)
    {
        public Point StartPoint { get; set; } = startPoint;
        public Point LastPoint { get; set; } = lastPoint;
        public Point CurrentPoint { get; set; } = currentPoint;
        public Color Color { get; set; } = color;
        public int Size { get; set; } = size;
    }
}