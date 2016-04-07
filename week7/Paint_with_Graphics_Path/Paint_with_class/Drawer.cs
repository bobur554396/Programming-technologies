using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Paint_with_class
{
    public enum Shape { Pencil, Rectangle, Circle, Line};

    class Drawer
    {
        public Graphics g;
        public GraphicsPath path;
        public Bitmap btm;
        public PictureBox picture;
        public Shape shape;
        public Pen pen;

        public bool paintStarted = false;
        public Point prev;

        public Drawer(PictureBox p) {
            this.picture = p;
            pen = new Pen(Color.Red);
            
            OpenImage("");

            picture.Paint += Picture_Paint;
        }

        public void Picture_Paint(object sender, PaintEventArgs e)
        {
            if (path != null) 
            {
                e.Graphics.DrawPath(pen, path);
            }
        }

        public void saveLastPath() 
        {
            if (path != null)
            {
                g.DrawPath(pen, path);
            }
        }



        public void Draw(Point cur) {

            switch (shape) 
            { 
                case Shape.Pencil:
                    g.DrawLine(pen, prev, cur);
                    prev = cur;
                    break;
                case Shape.Rectangle:
                    path = new GraphicsPath();
                    path.AddRectangle(new Rectangle(prev.X,prev.Y,cur.X-prev.X,cur.Y-prev.Y));
                    break;
                case Shape.Circle:
                    path = new GraphicsPath();
                    path.AddEllipse(new Rectangle(prev.X, prev.Y, cur.X - prev.X, cur.Y - prev.Y));
                    break;
                case Shape.Line:
                    path = new GraphicsPath();
                    path.AddLine(prev, cur);
                    break;
                default:
                    break;
            }
            picture.Refresh();
        }

        public void OpenImage(string filename)
        {
            btm = filename == "" ? new Bitmap(picture.Width, picture.Height) 
                : new Bitmap(filename);

            /*if (filename == "")
            {
                btm = new Bitmap(picture.Width, picture.Height);
            }
            else {
                btm = new Bitmap(filename);
            }*/
            g = Graphics.FromImage(btm);
            picture.Image = btm;
        }


        public void SaveImage(string filename)
        {
            btm.Save(filename);
        }





    }
}
