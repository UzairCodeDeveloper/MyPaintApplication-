using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal class Rectangle : Shape
    {
    
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x1, int y1, int width, int height)
        {
            X = x1;
            Y = y1;
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(OutLineColor, 2);
            g.DrawRectangle(pen, X, Y, Width, Height);
        }

        public override string ToString()
        {
            return "RECT," + X + "," + Y + "," + Width + "," + Height;
        }

    }
}
