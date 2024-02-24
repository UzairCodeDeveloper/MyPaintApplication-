using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal class Line : Shape
    {
        public Line(int x1, int y1, int x2, int y2)
        {
            X = x1;
            Y = y1;
            X2 = x2;
            Y2 = y2;
        }

        public int X2 { get; set; }
        public int Y2 { get; set; }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 2);
            g.DrawLine(pen, X, Y, X2, Y2);
        }

        public override string ToString()
        {
            return "LINE," + X + "," + Y + "," + X2 + "," + Y2;
        }
    }
}
