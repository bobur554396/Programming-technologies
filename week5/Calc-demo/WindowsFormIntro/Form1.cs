using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace WindowsFormIntro
{
    public partial class Form1 : Form
    {
        private Calc calc = new Calc();

        public Form1()
        {
            InitializeComponent();
        }

        private void numbers_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            display.Text += b.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            calc.first = double.Parse(display.Text);
            calc.operation = b.Text;
            display.Text = "";
        }

        private void result_click(object sender, EventArgs e)
        {
            calc.second = double.Parse(display.Text);
            calc.Calculate();
            display.Text = calc.Result.ToString();
        }

        private void clear_all(object sender, EventArgs e)
        {
            calc.first = 0;
            calc.second = 0;
            calc.Result = 0;
            calc.operation = "";
            display.Text = "";
        }

    }
}
