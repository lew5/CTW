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
    public partial class UCCambio_2 : UserControl
    {
        public UCCambio_2()
        {
            InitializeComponent();
        }

        public string Cambio
        {
            get => glbl_nombreCambio.Text;
            set
            {
                glbl_nombreCambio.Text = value;
            }
        }
        public string DetalleCambio
        {
            get => glbl_detalleCambio.Text;
            set
            {
                glbl_detalleCambio.Text = value;
            }
        }

        private void UCCambio_2_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            BringToFront();
        }
    }
}
