using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Rotate_example
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen myPen;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            myPen = new Pen(Color.Red, 3);
        }

        private void Rotate(object sender, PaintEventArgs e)
        {
            Rectangle r = new Rectangle(30, 30, 150, 80);

            g.TranslateTransform(r.Left + (r.Width / 2), r.Top + (r.Height / 2));
            g.RotateTransform(45);
            g.DrawRectangle(myPen, r);
        }


    }
}
