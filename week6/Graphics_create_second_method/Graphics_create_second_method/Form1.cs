using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphics_create_second_method
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen pen;
        SolidBrush fill;
        public Form1()
        {
            InitializeComponent();
            pen = new Pen(Color.Red);
            pen.Width = 3;
            fill = new SolidBrush(Color.Blue);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawLine(pen, 10, 10, 500, 10);
            g.DrawRectangle(pen, new Rectangle(20, 20, 100, 100));
            g.FillEllipse(fill, new Rectangle(140, 20, 100, 100));
        }
    }
}
