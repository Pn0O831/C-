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
    public partial class Form3 : Form
    {
        private readonly string[] days = { "Mon", "Tes", "Wed", "Thu", "Fri", "Sat", "Sun" };
        private readonly string[] years = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec" };

        private void CheckAllCheckBoxes()
        {
            bool allchecked = 
                chk1.Checked && chk2.Checked && chk3.Checked;

            btnAction.Enabled = allchecked;
        }

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            RadioButton[] dayRdbs = { rdbMon, rdbTue, rdbWed, rdbThu, rdbFri, rdbSat, rdbSun };
            for (int i = 0; i < dayRdbs.Length; i++)
                dayRdbs[i].Text = days[i];

            rdbDays.Checked = true;
            rdbYears.Checked = false;

            cmbSelect.Items.Clear();
            cmbSelect.Items.Add("");
            cmbSelect.Items.AddRange(days);
            cmbSelect.SelectedIndex = -1;

            pnlImage.BackgroundImage = Image.FromFile("sample.png");
            pnlImage.BackgroundImageLayout = ImageLayout.Center;

        }

        private void rdbDays_CheckedChanged(object sender, EventArgs e)
        {
            cmbSelect.Items.Clear();
            if (rdbDays.Checked)
            {
                cmbSelect.Items.Add("");
                cmbSelect.Items.AddRange(days);
                cmbSelect.SelectedIndex = 0;
                lblDaysRight.Text = rdbDays.Text;
            }
            else if (rdbYears.Checked)
            {
                cmbSelect.Items.Add("");
                cmbSelect.Items.AddRange(years);
                cmbSelect.SelectedIndex = 0;
                lblDaysRight.Text = rdbYears.Text;
            }
        }

        private void rdbWeekday_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;

            if (rdb != null && rdb.Checked)
            {
                switch (rdb.Name)
                {
                    case "rdbMon": lblDaysLeft.Text = rdbMon.Text; break;
                    case "rdbTue": lblDaysLeft.Text = rdbTue.Text; break;
                    case "rdbWed": lblDaysLeft.Text = rdbWed.Text; break;
                    case "rdbThu": lblDaysLeft.Text = rdbThu.Text; break;
                    case "rdbFri": lblDaysLeft.Text = rdbFri.Text; break;
                    case "rdbSat": lblDaysLeft.Text = rdbSat.Text; break;
                    case "rdbSun": lblDaysLeft.Text = rdbSun.Text; break;
                    default: lblDaysLeft.Text = "Days"; break;
                }
            }
        }

        private void chk_CheckedChanged(object sender, EventArgs e)
        {
            CheckAllCheckBoxes();
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            MessageBox.Show(MessageManage.Msg4, MessageManage.Title3);
        }

        private void btnAction_MouseEnter(object sender, EventArgs e)
        {
            btnAction.BackColor = Color.Black;
            btnAction.ForeColor = Color.Yellow;
            btnAction.Cursor = Cursors.Hand;
        }

        private void btnAction_MouseLeave(object sender, EventArgs e)
        {
            btnAction.BackColor = Color.Yellow;
            btnAction.ForeColor = Color.Black;
        }

        private void rdbImageLayout_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton;
            if (rdb == null && !rdb.Checked) return;
            switch(rdb.Name)
            {
                case "rdbZoom":
                    pnlImage.BackgroundImageLayout = ImageLayout.Zoom;
                    break;
                case "rdbStretch":
                    pnlImage.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case "rdbCenter":
                    pnlImage.BackgroundImageLayout = ImageLayout.Center;
                    break;
            }
        }
    }
}
