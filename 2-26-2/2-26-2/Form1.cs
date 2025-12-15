using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_26_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            if (string.IsNullOrEmpty(input) )
            {
                label1.Text = "からっぽ";
                label1.ForeColor = Color.Yellow;
            }
            else
            {
                CheckInput(input);
            }
        }

        private void CheckInput(string input)
        {
            bool hasYama = input.Contains("山");
            bool hasUmi = input.Contains("海");

            if (hasYama &&  hasUmi)
            {
                label1.Text = "どちらも含まれている";
                label1.ForeColor = Color.Red;
            }
            else if (hasYama)
            {
                label1.Text = "山が含まれている";
                label1.ForeColor = Color.Green;
            }
            else if (hasUmi)
            {
                label1.Text = "海が含まれている";
                label1.ForeColor = Color.Blue;
            }
            else
            {
                label1.Text = "どちらも含まれていない";
                label1.ForeColor = Color.Black;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
