using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente_TulaWoW.test
{
    public partial class tUCscroll : UserControl
    {
        public tUCscroll()
        {
            InitializeComponent();
        }

        private int scroll = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            scroll += 200;
            panel1.Location = new Point(panel1.Location.X, scroll);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            scroll -= 200;
            panel1.Location = new Point(panel1.Location.X, scroll);
        }
    }
}
