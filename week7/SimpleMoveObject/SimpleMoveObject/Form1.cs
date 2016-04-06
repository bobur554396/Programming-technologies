using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SimpleMoveObject
{
    public partial class Form1 : Form
    {
        Graphics g;
        Pen p;
        Timer t;

        float x = 0;
        float y = 0;
        float w = 100;
        float h = 100;

        float dx = 10;
        float dy = 10;

        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            p = new Pen(Color.Red, 2);
            t = new Timer();
            t.Tick += new EventHandler(MoveObject);
            t.Start();
        }

        private void MoveObject(object sender, EventArgs e) 
        {
            if (x + w > Width) {
                dx = -10;
            }
            else if (x < 0) {
                dx = 10;
            }

            if (y + h > Height) 
            {
                dy = -10;
            }
            else if (y < 0) 
            {
                dy = 10;
            }

            x += dx;
            y += dy;
            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawEllipse(p, x, y, w, h);
        }


    }
}
