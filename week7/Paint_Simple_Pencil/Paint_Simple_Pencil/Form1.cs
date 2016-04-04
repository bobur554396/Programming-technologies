using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Paint_Simple_Pencil
{
    public partial class Form1 : Form
    {
        Graphics g;
        Bitmap btm;
        Pen pen;

        bool paintStarted = false;

        Point prev;
        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
            pen = new Pen(Color.Red);
            pictureBox1.Image = btm;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                prev = e.Location;
                paintStarted = true;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (paintStarted)
            {
                Point cur = e.Location;
                g.DrawLine(pen, prev, cur);
                prev = cur;
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            paintStarted = false;
        }
    }
}
