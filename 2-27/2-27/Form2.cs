using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_27
{
    public partial class Form2 : Form
    {
        public string SourceValue { get; set; }
        public string ReturnValue { get; private set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lblSourceValue.Text = SourceValue;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string source = lblSourceValue.Text;
            string[] parts = source.Split(',');
            if(parts.Length >= 4)
            {
                txtSplit1.Text = parts[0].Trim();
                txtSplit2.Text = parts[1].Trim();
                txtSplit3.Text = parts[2].Trim();
                txtSplit4.Text = parts[3].Trim();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReturnValue = txtResult.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnTrimA_Click(object sender, EventArgs e)
        {
            txtSplit1.Text = txtSplit1.Text.Trim();
            txtSplit2.Text = txtSplit2.Text.Trim();
            txtSplit3.Text = txtSplit3.Text.Trim();
            txtSplit4.Text = txtSplit4.Text.Trim();
        }

        private void btnTrimB_Click(object sender, EventArgs e)
        {
            txtSplit1.Text = txtSplit1.Text.Replace(" ", "");
            txtSplit2.Text = txtSplit2.Text.Replace(" ", "");
            txtSplit3.Text = txtSplit3.Text.Replace(" ", "");
            txtSplit4.Text = txtSplit4.Text.Replace(" ", "");
        }

        private void btnJoin_Click(object sender, EventArgs e)
        {
            string[] values = {txtSplit1.Text, txtSplit2.Text, txtSplit3.Text, txtSplit4.Text};
            txtResult.Text = string.Join(",", values);
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            int n = (int)numStair.Value;
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sb.Append(j);
                }
                sb.AppendLine();
            }

            rtbLoopResult.Text = sb.ToString();
        }
    }
}
