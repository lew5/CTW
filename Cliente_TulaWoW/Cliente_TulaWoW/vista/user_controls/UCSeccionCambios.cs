using System;
using System.Drawing;
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
            vsc = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(customFlowLayoutPanel1,gunaVScrollBar1,true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UCChangelogCard_2 uCChangelogCard2 = new UCChangelogCard_2();
            uCChangelogCard2.FechaCambio = "11/11/2020";
            uCChangelogCard2.nuevoCambio("awa", "awAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciaAhora los Buffos duran más tiempo y gastan menos maná, así se fomenta darle buffos a los demás jugadores en el leveleo y que enserio haga una diferenciae");
            customFlowLayoutPanel1.Controls.Add(uCChangelogCard2);
        }
    }
}
