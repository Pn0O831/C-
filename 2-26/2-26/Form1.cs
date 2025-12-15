using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_26
{
    public partial class Form1 : Form
    {
        public Form1()
       {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
            button1.Click += Button1_Click;    
        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out int value))
            {
                if (value < 5)
                {
                    if (value % 2 == 0)
                        label1.Text = "5より小さい2の倍数";
                    else
                        label1.Text = "5より小さい2の倍数ではない";
                }
                else
                {
                    if (value % 2 == 0)
                        label1.Text = "5以上　2の倍数";
                    else
                        label1.Text = "5以上　2の倍数ではない";
                }
            }
        }
    }
}