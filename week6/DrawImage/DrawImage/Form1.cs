using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DrawImage
{
    public partial class Form1 : Form
    {

        Graphics g;
        Image img;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            img = Image.FromFile(@"1.jpg");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g.DrawImage(img, 0, 0);
        }
    }
}
