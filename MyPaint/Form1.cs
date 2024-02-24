using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public enum SHAPETOOLS
    {
        SELECT,
        LINE,
        RECTANGLE,
        CIRCLE
    }
    public partial class Form1 : Form
    {

        TreeNode rootNode;
        public Form1()
        {
            InitializeComponent();

            myDrawing.OutLineColor = Color.Black;
        }

        private void selectToolStripMenuItem_Click(object sender, EventArgs e)
        {

            myDrawing.SelectedTool = SHAPETOOLS.SELECT;

        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Line tool selected");
            myDrawing.SelectedTool = SHAPETOOLS.LINE;
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Rectangle tool selected");
            myDrawing.SelectedTool = SHAPETOOLS.RECTANGLE;

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Circle tool selected");
            myDrawing.SelectedTool = SHAPETOOLS.CIRCLE;

        }


        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Usman Vecter Graphics (.uvg)|*.uvg";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(saveFileDialog.FileName);


                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);


               // for (int i = 0; i < Shapes.Count; i++)
                {

                //    streamWriter.WriteLine(Shapes[i].ToString());
                
                }

                streamWriter.Close();
            
            }

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
        }


        private void tsbColorDialog_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {

                myDrawing.OutLineColor = colorDialog.Color;
            }
        }

        private void myDrawing_MouseUp(object sender, MouseEventArgs e)
        {
            if (myDrawing.SelectedShape != null)
            {
                pgShape.SelectedObject = myDrawing.SelectedShape;
                TreeNode tempnode = rootNode.Nodes.Add(myDrawing.SelectedShape.ToString());
                tempnode.Tag = myDrawing.SelectedShape;
            }
        }

        private void pgShape_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            myDrawing.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           rootNode = tvShapes.Nodes.Add("Drawing");
        }

        private void pgShape_Click(object sender, EventArgs e)
        {

        }

        private void tvShapes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvShapes.SelectedNode != null)
            {
                pgShape.SelectedObject = tvShapes.SelectedNode.Tag;
            }
        }
    }


}
