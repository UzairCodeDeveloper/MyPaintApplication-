using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    internal class Ellipse : Shape
    {
        public Ellipse(int x1, int y1, int v1, int v2, Color color)
        {
            X = x1;
            Y = y1;
            HDiameter = v1;
            VDiameter = v2;
            OutLineColor = color;
        }

        public int HDiameter { get; set; }
        public int VDiameter { get; set; }

        public override void Draw(Graphics g)
        {
            Pen pen = new Pen(OutLineColor, 2);
            g.DrawEllipse(pen, X, Y, HDiameter, VDiameter);
        }

        public override string ToString()
        {
            return "CIRC," + X + "," + Y + "," + HDiameter + "," + VDiameter;
        }
    }
}
