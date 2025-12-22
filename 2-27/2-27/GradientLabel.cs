using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace _2_27
{


    public class GradientLabel : Label
    {
        public Color StartColor { get; set; } = Color.Blue;
        public Color EndColor { get; set; } = Color.White;

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

}
