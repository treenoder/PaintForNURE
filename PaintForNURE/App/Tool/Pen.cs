using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintForNURE.App.Tool
{
    internal class Pen : ITool
    {
        public ToolParams Params { get; set; }
        private Graphics _g;
        private System.Drawing.Pen _pen;

        public Pen(Graphics g, ToolParams p)
        {
            Params = p;
            _g = g;
            _pen = new System.Drawing.Pen(p.Color, p.Size);
            _pen.StartCap = LineCap.Round;
            _pen.EndCap = LineCap.Round;
        }

        public void Update()
        {
            _pen.Color = Params.Color;
            _pen.Width = Params.Size;
        }

        public void Draw()
        {
            if (Params.LastPoint == Params.CurrentPoint)
            {
                Params.CurrentPoint = Params.CurrentPoint with { X = Params.CurrentPoint.X + 1 };
            }

            _g.DrawLine(_pen, Params.LastPoint, Params.CurrentPoint);
        }
    }
}