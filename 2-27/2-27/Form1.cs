using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_27
{
    public partial class Form1 : Form
    {
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
    }
}
