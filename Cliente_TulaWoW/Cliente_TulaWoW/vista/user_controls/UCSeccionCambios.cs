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
    public partial class UCSeccionCambios : UserControl
    {

        Guna.UI.Lib.ScrollBar.PanelScrollHelper vsc;
        public UCSeccionCambios()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCChangelogCard uCChangelogCard = new UCChangelogCard();
            uCChangelogCard.FechaCambio = "11/11/2020";
            uCChangelogCard.nuevoDetalleCambio("awa", "awAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciae");
            customFlowLayoutPanel1.Controls.Add(uCChangelogCard);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
