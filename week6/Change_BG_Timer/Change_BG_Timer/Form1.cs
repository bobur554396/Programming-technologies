using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Change_BG_Timer
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);
            timer1.Start();
            timer1.Interval = 200;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            brush.Color = brush.Color == Color.Red ? Color.Blue : Color.Red;
            g.FillRectangle(brush, 0, 0, this.Width, this.Height);
        }

    }
}
