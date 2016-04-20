using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BitMap
{
    public partial class Form1 : Form
    {
        Graphics g;
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Bitmap image1 = new Bitmap(@"1.jpg");
            Bitmap image2 = new Bitmap(@"1.jpg");
            Bitmap image3 = new Bitmap(@"1.jpg");
            Bitmap image4 = new Bitmap(@"1.jpg");

            for (int i = 0; i < image1.Width; i++)
            {
                for (int j = 0; j < image1.Height; j++)
                {
                    Color curColor = image1.GetPixel(i, j);
                    Color newColor1 = Color.FromArgb(255, curColor.R, 0, 0);
                    Color newColor2 = Color.FromArgb(255, 0, curColor.G, 0);
                    Color newColor3 = Color.FromArgb(255, 0, 0, curColor.B);
                    Color newColor4 = Color.FromArgb(255, curColor.R, curColor.G, curColor.B);
                    image1.SetPixel(i, j, newColor1);
                    image2.SetPixel(i, j, newColor2);
                    image3.SetPixel(i, j, newColor3);
                    image4.SetPixel(i, j, newColor4);
                }
            }
            pictureBox1.Image = image1;
            pictureBox2.Image = image2;
            pictureBox3.Image = image3;
            pictureBox4.Image = image4;

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Color c = colorDialog1.Color;
            button1.BackColor = c;
        }
    }
}
