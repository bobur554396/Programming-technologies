using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Paint_with_class
{
    public enum Tool { Pencil, Rectangle, Circle };

    class Drawer
    {
        private Graphics g;
        private Bitmap btm;
        private PictureBox picture;
        public Tool tool;
        public Pen pen;

        public bool paintStarted = false;
        public Point prev;

        public Drawer(PictureBox p) {
            this.picture = p;
            btm = new Bitmap(picture.Width, picture.Height);
            g = Graphics.FromImage(btm);
            picture.Image = btm;
            pen = new Pen(Color.Red);

        }


        public void Draw(Point cur) {

            switch (tool) 
            { 
                case Tool.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Tool.Rectangle:
                    break;
                case Tool.Circle:
                    break;
                default:
                    break;
            }
            picture.Refresh();
        }



        public void Save() 
        {
            btm.Save("1.jpg");    
        }





    }
}
