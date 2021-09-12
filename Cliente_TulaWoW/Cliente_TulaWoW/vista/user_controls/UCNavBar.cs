using System;
using System.Drawing;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCNavBar : UserControl
    {


        public event EventHandler ButtonJuegoClick;
        public event EventHandler ButtonCambiosClick;
        public event EventHandler ButtonTiendaClick;



        public UCNavBar()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void ucNavBar_buttonJuego_ButtonClick(object sender, EventArgs e)
        {
            ButtonJuegoClick?.Invoke(this, e);
        }

        private void ucNavBar_buttonCambios_ButtonClick(object sender, EventArgs e)
        {
            ButtonCambiosClick?.Invoke(this, e);
        }

        private void ucNavBar_buttonTienda_ButtonClick(object sender, EventArgs e)
        {
            ButtonTiendaClick?.Invoke(this, e);
        }
    }
}
