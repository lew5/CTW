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
    public partial class UCChangelogCard_2 : UserControl
    {
        public UCChangelogCard_2()
        {
            InitializeComponent();
        }

        public string FechaCambio
        {
            get => glbl_fechaCambio.Text;
            set
            {
                glbl_fechaCambio.Text = value;
            }

        }

        public void nuevoCambio(string cambio, string detallecambio)
        {
            UCCambio nCCambio = new UCCambio();
            glpnl_contenedor.Controls.Add(nCCambio);
            nCCambio.Cambio = cambio.ToUpper();
            nCCambio.DetalleCambio = detallecambio;
        }

        private void UCChangelogCard_2_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            BringToFront();
        }
    }
}
