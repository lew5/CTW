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
    public partial class UCSeccionTienda : UserControl
    {
        public UCSeccionTienda()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
        }

        private void customGLabel1_Click(object sender, EventArgs e)
        {
            if (panel2.Visible)
            {
                customGLabel1.Text = "Item store +";
                panel2.Visible = false;
            }
            else
            {
                customGLabel1.Text = "Item store -";
                panel2.Visible = true;
                panel3.Visible = false;
                customGLabel2.Text = "Character services +";
            }
        }

        private void customGLabel2_Click(object sender, EventArgs e)
        {
            if (panel3.Visible)
            {
                customGLabel2.Text = "Character services +";
                panel3.Visible = false;
            }
            else
            {
                customGLabel2.Text = "Character services -";
                panel3.Visible = true;
                panel2.Visible = false;
                customGLabel1.Text = "Item store +";
            }
        }
    }
}
