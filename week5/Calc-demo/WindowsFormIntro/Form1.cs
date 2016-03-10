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

        private void button1_Click(object sender, EventArgs e)
        {
            result.Text = calc.Result.ToString();
        }

        private void sum_Click(object sender, EventArgs e)
        {
            calc.Calculate("+");
        }

        private void subt_Click(object sender, EventArgs e)
        {
            calc.Calculate("-");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = textBox1.Text;
            if (!double.TryParse(s, out calc.first))
                textBox1.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string s = textBox2.Text;
            if (!double.TryParse(s, out calc.second))
                textBox2.Text = "";
        }


    }
}
