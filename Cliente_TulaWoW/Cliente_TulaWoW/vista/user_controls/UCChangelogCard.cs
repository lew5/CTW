using HtmlAgilityPack;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCChangelogCard : UserControl
    {

        private string fechaCambio = "Changes made on 2021/08/14";
        private string cambio = "a";       
        private string detalleCambio = "Cambios";
        //private string url = "http://www.tula-wow.com/changelog";
        public UCChangelogCard()
        {
            InitializeComponent();
        }



        public string FechaCambio
        {
            get => fechaCambio;
            set
            {
                fechaCambio = value;
                glbl_fechaCambio.Text = fechaCambio;
            }

        }

        public void nuevoDetalleCambio(string cambio,string detallecambio)
        {
            UCCambio nCCambio = new UCCambio();
            glpnl_contenedor.Controls.Add(nCCambio);
            nCCambio.Cambio = cambio.ToUpper();
            nCCambio.DetalleCambio = detallecambio;
            this.Height += nCCambio.Height;
        }

        private void UCChangelogCard_Load(object sender, System.EventArgs e)
        {
            Dock = DockStyle.Top;
            BringToFront();
        }
    }
}
