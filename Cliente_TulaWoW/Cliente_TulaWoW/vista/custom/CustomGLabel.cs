using System.Drawing;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.custom
{
    class CustomGLabel : Label
    {
        public CustomGLabel()
        {
            this.ForeColor = Color.FromArgb(140, 224, 224, 224);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            Rectangle rc = this.ClientRectangle;
            StringFormat fmt = new StringFormat(StringFormat.GenericTypographic);
            using (var br = new SolidBrush(this.ForeColor))
            {
                e.Graphics.DrawString(this.Text, this.Font, br, rc, fmt);
            }
        }

    }
}
