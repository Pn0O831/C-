using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_27
{
    public partial class Form1 : Form
    {
        private class GradientLabel : Label
        {
            public Color StartColor { get; set; } = Color.LightBlue;
            public Color EndColor { get; set; } = Color.LightGreen;

            protected override void OnPaint(PaintEventArgs e)
            {
                using (LinearGradientBrush brush =
                    new LinearGradientBrush(this.ClientRectangle, StartColor, EndColor, 90F))
                {
                    e.Graphics.FillRectangle(brush, this.ClientRectangle);
                }

                TextRenderer.DrawText(
                    e.Graphics,
                    this.Text,
                    this.Font,
                    this.ClientRectangle,
                    this.ForeColor,
                    TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                );
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "開くファイルを選択してください";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "すべてのファイル (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = ofd.FileName;
            }
        }

        private void btnDisplayFile_Click(object sender, EventArgs e)
        {
            try
            {
                if(File.Exists(txtFilePath.Text))
                {
                    string content = File.ReadAllText(txtFilePath.Text);
                    lblFileStatus.Text = content;
                }
                else
                {
                    MessageBox.Show(MessageManage.Msg2,MessageManage.Title4,MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,MessageManage.Title4,MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnYellow_Click(object sender, EventArgs e) => lblReturnValue.BackColor = Color.Yellow;

        private void btnGreen_Click(object sender, EventArgs e) => lblReturnValue.BackColor = Color.Green;

        private void btnBlue_Click(object sender, EventArgs e) => lblReturnValue.BackColor = Color.Blue;

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            lblClock.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnPushTop_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageManage.Msg1, MessageManage.Title3, MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (Form2 f2 = new Form2())
                {
                    f2.SourceValue = lblFileStatus.Text;
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        lblReturnValue.Text = f2.ReturnValue;
                    }
                }
            }
        }

        private void btnPushRight_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(MessageManage.Msg1,MessageManage.Title3,MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                using (Form3 f3 = new Form3())
                {
                    f3.ShowDialog();
                }
            }
        }
    }
}
