using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPaint
{
    public abstract class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Bitmap MyBitmap { get; set; }        
        public Color OutLineColor { get; set; } = Color.Black;

        public abstract void Draw(Graphics g);
    }
}
