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
    public partial class SearchBar : UserControl
    {

        public string SearchText
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        
        }

        public SearchBar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
