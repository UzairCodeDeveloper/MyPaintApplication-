using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class DrawingBoard : UserControl
    {

        int X1, Y1;
        int X2, Y2;

        bool IsDrawing = false;

        List<Shape> Shapes = new List<Shape>();

        SHAPETOOLS selectedTool = SHAPETOOLS.SELECT;

        public Color OutLineColor { get; set; }

        public SHAPETOOLS SelectedTool
        {
            get { return selectedTool; }
            set { selectedTool = value; }
        }

        public Shape selectedShape;
        public Shape SelectedShape
        {
            get {
                return selectedShape;
            }
        }

        public DrawingBoard()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);

        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            if (e.Graphics != null)
            {


                foreach (Shape s in Shapes)
                {
                    s.Draw(e.Graphics);
                }

                Pen pen = new Pen(OutLineColor, 2);

                switch (SelectedTool)
                {
                    case SHAPETOOLS.LINE:
                        e.Graphics.DrawLine(pen, X1, Y1, X2, Y2);
                        break;
                    case SHAPETOOLS.RECTANGLE:
                        e.Graphics.DrawRectangle(pen, X1, Y1, X2 - X1, Y2 - Y1);
                        break;
                    case SHAPETOOLS.CIRCLE:
                        e.Graphics.DrawEllipse(pen, X1, Y1, X2 - X1, Y2 - Y1);
                        break;
                }
            }

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            X1 = e.X;
            Y1 = e.Y;
            IsDrawing = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            X2 = e.X;
            Y2 = e.Y;
            Invalidate();
            IsDrawing = false;

            switch (SelectedTool)
            {
                case SHAPETOOLS.LINE:
                    Shapes.Add(new Line(X1, Y1, X2, Y2));
                    break;
                case SHAPETOOLS.RECTANGLE:
                    Shapes.Add(new Rectangle(X1, Y1, X2 - X1, Y2 - Y1));
                    break;
                case SHAPETOOLS.CIRCLE:
                    Shapes.Add(new Ellipse(X1, Y1, X2 - X1, Y2 - Y1,OutLineColor));
                    break;
            }

            selectedShape = Shapes[Shapes.Count - 1];

        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsDrawing)
            {
                X2 = e.X;
                Y2 = e.Y;
                Invalidate();
            }
        }
    }
}
