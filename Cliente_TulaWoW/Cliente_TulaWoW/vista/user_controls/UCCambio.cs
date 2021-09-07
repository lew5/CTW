using System;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCCambio : UserControl
    {
        private string cambio = "";
        private string detalleCambio = "";

        public UCCambio()
        {
            InitializeComponent();
        }

        public string Cambio
        {
            get => cambio;
            set
            {
                cambio = value;
                glbl_cambio.Text = cambio;
            }
        }
        public string DetalleCambio
        {
            get => detalleCambio;
            set
            {
                detalleCambio = value;
                glbl_detalleCambio.Text = detalleCambio;
                this.Height = glbl_detalleCambio.Height+40;
            }
        }

        private void UCCambio_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Top;
            BringToFront();
        }
    }
}
