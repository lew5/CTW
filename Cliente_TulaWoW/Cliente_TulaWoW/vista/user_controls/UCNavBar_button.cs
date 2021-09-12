using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Cliente_TulaWoW.vista.user_controls
{
    public partial class UCNavBar_button : UserControl
    {
        private string txt = "JUEGO";
        private bool check = false;

        public event EventHandler ButtonClick;
        public UCNavBar_button()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;
            glbl_Text.ForeColor = Color.FromArgb(170, 224, 224, 224);
        }

        public string Txt
        {
            get => txt;
            set
            {
                txt = value;
                glbl_Text.Text = txt;
                this.Size = glbl_Text.Size;
            }
        }

        public bool Check
        {
            get => check;
            set
            {
                check = value;
                if (check)
                {
                    glbl_Text.ForeColor = Color.FromArgb(255, 224, 224, 224);
                }
                else
                {
                    glbl_Text.ForeColor = Color.FromArgb(140, 224, 224, 224);
                }
            }
        }

        private void glbl_Text_MouseEnter(object sender, System.EventArgs e)
        {
            glbl_Text.ForeColor = Color.FromArgb(255, 224, 224, 224);
        }

        private void glbl_Text_MouseLeave(object sender, System.EventArgs e)
        {
            if (Check == false)
            {
                glbl_Text.ForeColor = Color.FromArgb(140, 224, 224, 224);
            }
        }

        private void glbl_Text_Click(object sender, System.EventArgs e)
        {
            foreach (UCNavBar_button NavBarbtn in Parent.Controls.OfType<UCNavBar_button>())
            {
                NavBarbtn.Check = false;
            }
            this.Check = true;
            ButtonClick?.Invoke(this, e);
        }
    }
}
