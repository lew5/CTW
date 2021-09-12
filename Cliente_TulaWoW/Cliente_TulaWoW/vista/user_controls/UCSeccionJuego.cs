using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCSeccionJuego : UserControl
    {
        public UCSeccionJuego()
        {
            InitializeComponent();
            gunaTransfarantPictureBox1.Location = new Point((glpnl_video.Width / 2) - (gunaTransfarantPictureBox1.Width / 2), (glpnl_video.Height / 2) - (gunaTransfarantPictureBox1.Height / 2));
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void gunaTransfarantPictureBox4_MouseEnter(object sender, EventArgs e)
        {

        }

        private void gtpbox_azerothcoreBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.azerothcore.org");
        }
    }
}
