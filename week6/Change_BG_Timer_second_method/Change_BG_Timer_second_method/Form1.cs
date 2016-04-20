using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Change_BG_Timer_second_method
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            brush = new SolidBrush(Color.Red);
            t.Tick += new EventHandler(ChangeColor);
            t.Interval = 1000;
            t.Start();
        }

        void ChangeColor(object sender, EventArgs e)
        {
            brush.Color = brush.Color == Color.Red ? Color.Green : Color.Red;
            g.FillRectangle(brush, 0, 0, this.Width, this.Height);

        }
    }
}
